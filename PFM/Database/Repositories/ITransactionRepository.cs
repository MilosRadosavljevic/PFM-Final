using PFM.Database.Entities;
using PFM.Models;

namespace PFM.Database.Repositories
{
    public interface ITransactionRepository
    {
        Task<TransactionEntity> GetTransactionById(string transactionId);
        Task<TransactionEntity> CreateTransaction(TransactionEntity transactionEntity);
        Task<PagedSortedListTransactions<TransactionEntity>> GetTransactions(int pageSize = 20, int page = 1, SortOrder sortOrder = SortOrder.Asc, string? sortby = null, DateTime? startDate = null, DateTime? endDate = null, string? transactionKind = null);
        Task<TransactionEntity> UpdateTransaction(TransactionEntity transactionEntity);
        Task<SpendingByCategory<SpendingInCategory>> GetSpendingsByCategory(string? categoryCode, DateTime? startDate, DateTime? endDate, Direction? direction);
        Task<TransactionSplitEntity> CreateTransactionSplit(TransactionSplitEntity splitEntity);
        Task DeleteTransactionSplits(TransactionEntity transactionEntity);
    }
}