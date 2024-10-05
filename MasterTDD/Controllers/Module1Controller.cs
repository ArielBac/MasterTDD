using MasterTDD.Services.Module1;
using Microsoft.AspNetCore.Mvc;

namespace MasterTDD.Controllers
{
    [Route("api/module-1")]
    [Produces("application/json")]
    [ApiController]
    public class Module1Controller : ControllerBase
    {
        [HttpGet("leap-year/{year}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetLeapYear([FromRoute] int year)
        {
            var isLeapYear = LeapYearService.Verify(year);

            if (isLeapYear)
                return Ok("Is Leap Year");

            return Ok("Is not Leap Year");
        }

        [HttpGet("fibonacci/{position}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetFebonaccciNumberAtPosition([FromRoute] int position)
        {
            return Ok(FibonacciService.GetNumberAtPosition(position));
        }
    }
}
