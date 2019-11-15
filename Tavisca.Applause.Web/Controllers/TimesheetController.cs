using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Tavisca.Applause.Web.Controllers
{
    [Route("api/timesheet")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult ProcessTimesheet(Stream stream, DateTime date, bool IsEndOfMonth)
        {
            return Ok();
        }
    }
}