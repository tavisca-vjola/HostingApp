using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private readonly IBadgeService _badgeService;
        public BadgesController(IBadgeService service)
        {
            _badgeService = service;
        }

        [HttpGet("badgetimeline")]
        public async Task<IActionResult> GetRecentWinners([FromQuery]string pageState,[FromQuery]int pageSize)
        {
            var result = await  _badgeService.GetRecentBadgeWinners(pageState,pageSize);
            return Ok(result);
        }
        
        [HttpGet("recentbadgewinners")]
        public async Task<IActionResult> GetRecentWinnersByBadgeType([FromQuery]int limit)
        {
            var result = await _badgeService.GetRecentWinnersByBadgeType(limit);
            return Ok(result);
        }
    }
}