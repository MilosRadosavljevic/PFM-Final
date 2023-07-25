using Microsoft.AspNetCore.Mvc;
using PFM.Services;
using PFM.Models;
using Microsoft.AspNetCore.Cors;

namespace PFM.Controllers
{
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    [Route("spending-analytics")]
    public class AnalyticsController : ControllerBase
    {
        IAnalyticsService _analyticsService;
        private readonly ILogger<TransactionController> _logger;

        public AnalyticsController(ILogger<TransactionController> logger, IAnalyticsService analyticsService)
        {
            _logger = logger;
            _analyticsService = analyticsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpendingAnalytics(
            [FromQuery(Name = "catcode")] string? categoryCode,
            [FromQuery(Name = "start-date")] DateTime? startDate,
            [FromQuery(Name = "end-date")] DateTime? endDate,
            [FromQuery] Direction? direction)
        {
            try
            {
                var spendingAnalytics = await _analyticsService.GetSpendingAnalytics(categoryCode, startDate, endDate, direction);
                return Ok(spendingAnalytics);
            }
            catch (CustomException ex)
            {
                if (ex.Problem is BusinessProblem)
                {
                    return new ObjectResult(ex.Problem) { StatusCode = 404 };
                }
                return new ObjectResult(ex.Problem) { StatusCode = 400 };
            }
        }
    }
}
