using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly IRulesService _rules;
        public RulesController(IRulesService rules)
        {
            _rules = rules;
        }

             
        [HttpGet("platform")]
        public async Task<IActionResult> GetPlatformRules()
        {
            var result =  await _rules.GetPlatformRules();
            return Ok(result);
        }
        
        [HttpGet("badges")]
        public async Task<IActionResult> GetBadgeRules()
        {
            var result =  await _rules.GetBadgeRules();
            return Ok(result);
        }

    }
}
