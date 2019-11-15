using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationService _service;
        public ConfigurationController(IConfigurationService service)
        {
            _service = service;
        }
        
        [HttpGet("{key}")]
        public async Task<IActionResult> Get(string key)
        {
            var result =  await _service.GetConfiguration(key);
            return Ok(result);
        }

        
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Configuration keyValue)
        {
            var result = await _service.AddConfiguration(keyValue);
            return Ok(result);
        }

        
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Configuration value)
        {
            var result = await _service.UpdateConfiguration(value);
            return Ok(result);
        }
        
    }
}
