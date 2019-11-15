using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsController : ControllerBase
    {
        private readonly IAwardService _awardService;
        public AwardsController(IAwardService service)
        {
            _awardService = service;            
        }

       
        [HttpGet("{awardname}")]        
        public async Task<IActionResult>GetMonthlyAwards( string awardName,[FromQuery] int month,[FromQuery] int year )
        {
            var result =  await _awardService.GetMonthlyAwards(awardName, month, year);
            return Ok(result);
        }
        
        [HttpGet]        
        public async Task<IActionResult> GetAnnualAwards([FromQuery] int year)
        {
            var result =  await _awardService.GetAnnualAwards( year);
            return Ok(result);
        }      

        [HttpGet("employee/{id}")]
        public async Task<IActionResult> GetAwardsOfAnEmployee(string id,[FromQuery]string pageState, [FromQuery]int pageSize)
        {
            var result =  await _awardService.GetAwardsOfAnEmployee(id,pageState,pageSize);
            return Ok(result);
        }
    }
}
