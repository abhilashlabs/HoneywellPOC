using System;
using HoneywellPOC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly SimpleInterest _simpleInterest;
        public InterestController(SimpleInterest simpleInterest)
        {
            _simpleInterest = simpleInterest;
        }

        [HttpPost("simpleInterest")]
        public IActionResult SimpleInterest(double amount, double year, double rate, int den = 100)
        {
            if (Double.IsNaN(rate))
                return BadRequest("Rate should not be empty");

            if (amount == 0 || year == 0 || rate == 0)
                return NoContent();

            if (amount < 0 || year < 0 || rate < 0)
                return BadRequest();

            var result = new ApiResponse
            {
                status = "success",
                result = _simpleInterest.CalculateInterest(amount, rate, year, den)
            };
            return Ok(result);

            
        }
    }
}
