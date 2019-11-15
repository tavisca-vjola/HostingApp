using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubStatisticsController : ControllerBase
    {
        private readonly IGithubStatisticsService _githubStatisticsService;
        public GithubStatisticsController(IGithubStatisticsService githubStatisticsService)
        {
            _githubStatisticsService = githubStatisticsService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetGithubStatistics()
        {
            var result =  await _githubStatisticsService.GetGithubStatitics();
            return Ok(result);
        }

        
    }
}
