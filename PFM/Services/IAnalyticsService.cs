using PFM.Models;

namespace PFM.Services
{
    public interface IAnalyticsService
    {
        Task<SpendingByCategory<SpendingInCategory>> GetSpendingAnalytics(string? categoryCode, DateTime? startDate, DateTime? endDate, Direction? direction);
    }
}