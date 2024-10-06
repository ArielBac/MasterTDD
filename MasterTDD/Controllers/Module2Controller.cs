using MasterTDD.Services.Module2;
using Microsoft.AspNetCore.Mvc;

namespace MasterTDD.Controllers
{
    [Route("api/module-2")]
    [Produces("application/json")]
    [ApiController]
    public class Module2Controller : ControllerBase
    {
        [HttpPost("password/validate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ValidatePassword([FromBody] string password)
        {
            var passwordValidator = new PasswordValidator();
            var result = passwordValidator.ValidatePassword(password);

            if (!result)
                return BadRequest("Invalid password");

            return Ok("Valid password.");
        }
    }
}
