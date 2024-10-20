using MasterTDD.Requests;
using MasterTDD.Services.Module3;
using Microsoft.AspNetCore.Mvc;

namespace MasterTDD.Controllers
{
    [Route("api/module-3")]
    [Produces("application/json")]
    [ApiController]
    public class Module3Controller : ControllerBase
    {
        [HttpPost("change-calculator")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeCalculator([FromBody] ChangeCalculatorRequest payment)
        {
            try
            {
                var result = ChangeCalculatorService.GetChange(payment.TotalCost, payment.TotalPaid);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
