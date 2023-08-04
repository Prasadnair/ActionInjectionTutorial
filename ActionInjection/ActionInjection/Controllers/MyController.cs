using ActionInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {


        [HttpGet("info")]
        public IActionResult GetInfo([FromServices] IMyService myService)
        {
            var info = myService.GetServiceInfo();
            return Ok(info);
        }
    }
}
