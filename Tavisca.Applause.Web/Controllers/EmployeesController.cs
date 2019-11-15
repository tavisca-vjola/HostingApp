using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetPaginatedEmployees([FromQuery]string pageState,[FromQuery] int pageSize)
        {
            var result = await _employeeService.GetPaginatedEmployees(pageState, pageSize);
            return Ok(result);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(string id)
        {
            var result =  await _employeeService.GetEmployeeById(id);
            return Ok(result);
        }

        

        [HttpGet("search/{employeename}")]
        public async Task<IActionResult> GetEmployeeByName(string employeename)
        {
            var result =  await _employeeService.GetEmployeeByName(employeename);
            return Ok(result);
        }


        [HttpGet("topperformers")]
        public async Task<IActionResult> GetTopPerformerByPoint([FromQuery]int limit)
        {
            var result =  await _employeeService.GetTopPerformersByPoint(limit);
            return Ok(result);
        }

    }
}
