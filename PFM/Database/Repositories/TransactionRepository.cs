using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PFM.Database.Entities;
using PFM.Models;

namespace PFM.Database.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        PfmDbContext _dbContext;

        public TransactionRepository(PfmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TransactionEntity> CreateTransaction(TransactionEntity newTransactionEntity)
        {
            _dbContext.Transactions.Add(newTransactionEntity);
            await _dbContext.SaveChangesAsync();
            return newTransactionEntity;
        }

        public async Task<PagedSortedListTransactions<TransactionEntity>> GetTransactions(
            int page = 1,
            int pageSize = 10,
            SortOrder sortOrder = SortOrder.Asc,
            string? sortBy = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            string? transactionKind = null
            )
        {

            var query = _dbContext.Transactions.Include(x=>x.Splits).AsQueryable();

            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling(totalCount * 1.0 / pageSize);

            if (!String.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "kind":
                        query = sortOrder == SortOrder.Asc ? query.OrderBy(x => x.Kind) : query.OrderByDescending(x => x.Kind);
                        break;
                }
            }
            else
            {
                query = query.OrderBy(x => x.Id);
            }

            BusinessProblem busProblem;

            if (!string.IsNullOrEmpty(transactionKind))
            {
                if (Enum.TryParse(transactionKind, out TransactionKind parsedKind))
                {
                    query = query.Where(x => x.Kind == parsedKind);
                }
                else
                {
                    busProblem = new BusinessProblem
                    {
                        ProblemLiteral = "Transaction-kind-does-not-exist",
                        ProblemMessage = "Transaction kind does not exist",
                        ProblemDetails = "Provided transaction kind does not exist"
                    };
                    throw new CustomException(busProblem);
                }

            }


            if (startDate.HasValue)
            if (endDate.HasValue)
            {
                query = query.Where(x => x.Date <= endDate.Value);
            }
            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            var transactions = await query.ToListAsync();            

            return new PagedSortedListTransactions<TransactionEntity>
            {
                TotalPages = totalPages,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                SortBy = sortBy,
                SortOrder = sortOrder,
                //StartDate = startDate,
                //EndDate = endDate,
                Items = transactions,
            };
        }

        public async Task<TransactionEntity> GetTransactionById(string transactionId)
        {
            return await _dbContext.Transactions.FirstOrDefaultAsync(x => x.Id.Equals(transactionId));
        }

        public async Task<TransactionEntity> UpdateTransaction(TransactionEntity updatedTransactionEntity)
        {
            _dbContext.Transactions.Update(updatedTransactionEntity);
            await _dbContext.SaveChangesAsync();
            return updatedTransactionEntity;
        }

        public async Task<SpendingByCategory<SpendingInCategory>> GetSpendingsByCategory(string? categoryCode, DateTime? startDate, DateTime? endDate, Direction? direction)
        {
            var query = _dbContext.Transactions.AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(x => x.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                query = query.Where(x => x.Date <= endDate.Value);
            }
            if (direction.HasValue)
            {
                query = query.Where(x => x.Direction == direction);
            }

            if (string.IsNullOrEmpty(categoryCode))
            {
                var transactions = await query.ToListAsync();

                var spendingAnalytics = transactions
                    .Where(c => c.catCode != null)
                    .GroupBy(t => t.catCode)
                    .Select(g => new SpendingInCategory
                    {
                        CatCode = g.Key,
                        Amount = Math.Round(g.Sum(x => x.Amount), 2),
                        Count = g.Count()
                    })
                    .ToList();

                var categories = _dbContext.Categories.AsQueryable();

                foreach (var group in spendingAnalytics.ToList())
                {
                    var category = categories.FirstOrDefault(c => c.Code == group.CatCode);
                    if (category != null && !string.IsNullOrEmpty(category.ParentCode))
                    {
                        // Provera da li kategorija ima parent-code
                        var mainCategory = categories.FirstOrDefault(c => c.Code == category.ParentCode);
                        if (mainCategory != null)
                        {
                            // Pronalazenje osnovne kategorije
                            var mainGroup = spendingAnalytics.FirstOrDefault(g => g.CatCode == mainCategory.Code);
                            if (mainGroup != null)
                            {
                                mainGroup.Amount += group.Amount;
                                mainGroup.Count += group.Count;
                                // Sprecavanje prikaza podkategorije
                                spendingAnalytics.Remove(group);
                            }
                            else
                            {
                                group.CatCode = mainCategory.Code;
                            }
                        }
                    }
                }
                return new SpendingByCategory<SpendingInCategory>
                {
                    Groups = spendingAnalytics
                };
            }
            else
            {
                var subCategories = await _dbContext.Categories
               .Where(c => c.ParentCode == categoryCode)
               .Select(c => c.Code)
               .ToListAsync();

                query = query.Where(x => x.catCode == categoryCode || subCategories.Contains(x.catCode));
                var transactions = await query.ToListAsync();

                var spendingAnalytics = transactions
                    .Where(c => c.catCode != null)
                    .GroupBy(t => t.catCode)
                    .Select(g => new SpendingInCategory
                    {
                        CatCode = g.Key,
                        Amount = Math.Round(g.Sum(x => x.Amount), 2),
                        Count = g.Count()
                    })
                    .ToList();

                return new SpendingByCategory<SpendingInCategory>
                {
                    Groups = spendingAnalytics
                };

            }
        }


        public async Task DeleteTransactionSplits(TransactionEntity transactionEntity)
        {
            var splitsToDelete = _dbContext.TransactionSplits.
                Where(x => x.TransactionId == transactionEntity.Id);
            _dbContext.TransactionSplits.RemoveRange(splitsToDelete);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TransactionSplitEntity> CreateTransactionSplit(TransactionSplitEntity splitEntity)
        {
            _dbContext.TransactionSplits.Add(splitEntity);
            await _dbContext.SaveChangesAsync();
            return splitEntity;
        }
    }
}