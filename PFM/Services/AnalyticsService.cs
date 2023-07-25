using AutoMapper;
using PFM.Database.Repositories;
using PFM.Models;

namespace PFM.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        ITransactionRepository _transactionRepository;
        ICategoryRepository _categoryRepository;

        IMapper _mapper;
        public AnalyticsService(ITransactionRepository transactionRepository, IMapper mapper, ICategoryRepository categoryRepository)
        {
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<SpendingByCategory<SpendingInCategory>> GetSpendingAnalytics(string? categoryCode, DateTime? startDate, DateTime? endDate, Direction? direction)
        {
            var category = _categoryRepository.GetCategoryByCode(categoryCode);

            if (category == null)
            {
                BusinessProblem busProblem = new BusinessProblem
                {
                    ProblemLiteral = "category-code-does-not-exist",
                    ProblemMessage = "Category code does not exist",
                    ProblemDetails = "Provided category code does not exist"
                };
                throw new CustomException(busProblem);
            }

            var spendings = await _transactionRepository.GetSpendingsByCategory(categoryCode, startDate, endDate, direction);
            return _mapper.Map<SpendingByCategory<SpendingInCategory>>(spendings);
        }
    }
}