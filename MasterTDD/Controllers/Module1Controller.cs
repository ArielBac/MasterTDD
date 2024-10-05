using Microsoft.AspNetCore.Mvc;

namespace MasterTDD.Controllers
{
    [Route("api/module-1")]
    [ApiController]
    public class Module1Controller : ControllerBase
    {
        [HttpGet("leap-year")]
        public IActionResult GetLeapYear([FromRoute] int year)
        {
            return Ok();
        }
    }
}
