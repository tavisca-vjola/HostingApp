using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetStatisticsController : ControllerBase
    {
        private readonly ITimeSheetStatisticsService _timeSheetStatisticsService;
        public TimeSheetStatisticsController(ITimeSheetStatisticsService timeSheetStatisticsService)
        {
            _timeSheetStatisticsService = timeSheetStatisticsService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetTimeSheetStatistics()
        {
            var result =  await _timeSheetStatisticsService.GetTimeSheetStatistics();
            return Ok(result);
        }
    }
}
