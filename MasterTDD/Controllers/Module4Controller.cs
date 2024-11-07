using MasterTDD.Requests;
using MasterTDD.Services.Module3;
using MasterTDD.Services.Module4;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterTDD.Controllers
{
    [Route("api/module-4")]
    [Produces("application/json")]
    [ApiController]
    public class Module4Controller : ControllerBase
    {
        [HttpPost("bowling-game")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult BowlingGame([FromBody] string input)
        {
            try
            {
                var result = BowlingGameService.Run(input);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
