using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IEmployeeActivityService _employeeActivityService;

        public ActivityController(IEmployeeActivityService employeeActivityService)
        {
            _employeeActivityService = employeeActivityService;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserActivity(string id, [FromQuery]string pageState, [FromQuery]int pageSize)
        {
            var result = await _employeeActivityService.GetActivityByEmployeeId(id, pageState, pageSize);
            return Ok(result);
        }

     

       
    }
}
