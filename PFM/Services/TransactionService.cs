using AutoMapper;
using PFM.Commands;
using PFM.Database.Entities;
using PFM.Database.Repositories;
using PFM.Models;

namespace PFM.Services
{
    public class TransactionService : ITransactionService
    {
        ITransactionRepository _transactionRepository;
        ICategoryRepository _categoryRepository;
        IMapper _mapper;


        public TransactionService(ITransactionRepository transactionRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Transaction> CreateTransaction(CreateTransactionCommand createTransactionCommand)
        {
            var checkIfTransactionExists = await CheckIfTransactionExistsAsync(createTransactionCommand.TransactionId);

            BusinessProblem busProblem;

            if (checkIfTransactionExists == true)
            {
                busProblem = new BusinessProblem
                {
                    ProblemLiteral = "transction-already-exist",
                    ProblemMessage = "Transaction already exist",
                    ProblemDetails = "Provided transaction already exist in database table 'transactions'"
                };
                throw new CustomException(busProblem);

            }
            var newTransactionEntity = _mapper.Map<TransactionEntity>(createTransactionCommand);
            await _transactionRepository.CreateTransaction(newTransactionEntity);
            return _mapper.Map<Transaction>(newTransactionEntity);

        }

        public async Task<PagedSortedListTransactions<Transaction>> GetTransactions(
            int page,
            int pageSize,
            SortOrder sortOrder,
            string? sortBy,
            DateTime? startDate,
            DateTime? endDate,
            string? transactionKind)
        {
            var transactions = await _transactionRepository.GetTransactions(page, pageSize, sortOrder, sortBy,
                startDate, endDate, transactionKind);
            return _mapper.Map<PagedSortedListTransactions<Transaction>>(transactions);
        }


        public async Task<bool> CheckIfTransactionExistsAsync(string transactionId)
        {
            var transaction = await _transactionRepository.GetTransactionById(transactionId);
            if (transaction == null)
            {
                return false;
            }
            return true;
        }

        public async Task<Transaction> CategorizeTransaction(string transctionId, CategorizeTransactionCommand categorizeTransactionCommand)
        {
            var transaction = await _transactionRepository.GetTransactionById(transctionId);
            var category = await _categoryRepository.GetCategoryByCode(categorizeTransactionCommand.CategoryCode);
            BusinessProblem busProblem;

            if (transaction == null)
            {
                busProblem = new BusinessProblem
                {
                    ProblemLiteral = "transction-id-does-not-exist",
                    ProblemMessage = "Transaction code does not exist",
                    ProblemDetails = "Provided transction id does not exist"
                };
                throw new CustomException(busProblem);
            }

            if (category == null)
            {
                busProblem = new BusinessProblem
                {
                    ProblemLiteral = "category-code-does-not-exist",
                    ProblemMessage = "Category code does not exist",
                    ProblemDetails = "Provided category code does not exist"
                };
                throw new CustomException(busProblem);
            }

            transaction.catCode = categorizeTransactionCommand.CategoryCode;
            await _transactionRepository.UpdateTransaction(transaction);
            return _mapper.Map<Transaction>(transaction);
        }

        public async Task<Transaction> CreateTransactionSplit(string transactionId, SplitTransactionCommand splitTransactionCommand)
        {
            double totalAmount = 0;
            var transactionEntity = await _transactionRepository.GetTransactionById(transactionId);
            ValidationProblem valProblem;
            BusinessProblem busProblem;
            List<Error> validationErrors = new List<Error>();

            if (transactionEntity == null)
            {
                busProblem = new BusinessProblem
                {
                    ProblemLiteral = "transaction-id-does-not-exist",
                    ProblemMessage = "Transaction id does not exist",
                    ProblemDetails = "Provided transaction id does not exist"
                };
                throw new CustomException(busProblem);
            }

            var exinstingCatCodeInCurrentSplit = new HashSet<string>();

            foreach (var split in splitTransactionCommand.Splits)
            {
                var category = await _categoryRepository.GetCategoryByCode(split.CategoryCode);
                if (category == null)
                {
                    busProblem = new BusinessProblem
                    {
                        ProblemLiteral = "category-code-does-not-exist",
                        ProblemMessage = "Transaction code does not exist",
                        ProblemDetails = "Provided category code does not exist"
                    };
                    throw new CustomException(busProblem);
                }

                totalAmount += split.Amount;

                if (exinstingCatCodeInCurrentSplit.Contains(split.CategoryCode))
                {
                    validationErrors.Add(new Error
                    {
                        Message = "Forbidden to split by the same category",
                        Tag = "catcode",
                        Err = "forbidden-split-by-same-category"
                    });
                    valProblem = new ValidationProblem
                    {
                        Errors = validationErrors
                    };
                    throw new CustomException(valProblem);
                }

                exinstingCatCodeInCurrentSplit.Add(split.CategoryCode);
            }

            if (totalAmount != transactionEntity.Amount)
            {
                validationErrors.Add(new Error
                {
                    Message = "Invalid total amount to split.",
                    Tag = "amount",
                    Err = "invalid-split-amount"
                });
                valProblem = new ValidationProblem
                {
                    Errors = validationErrors
                };
                throw new CustomException(valProblem);
            }

            await _transactionRepository.DeleteTransactionSplits(transactionEntity);

            foreach (var split in splitTransactionCommand.Splits)
            {
                var splitEntity = new TransactionSplitEntity
                {
                    TransactionId = transactionEntity.Id,
                    CategoryCode = split.CategoryCode,
                    Amount = split.Amount
                };

                await _transactionRepository.CreateTransactionSplit(splitEntity);
            }

            return _mapper.Map<Transaction>(transactionEntity);
        }
    }
}
