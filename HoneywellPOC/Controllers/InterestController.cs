using System;
using HoneywellPOC.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class InterestController : ControllerBase
    {
        private readonly SimpleInterest _simpleInterest;
        public InterestController(SimpleInterest simpleInterest)
        {
            _simpleInterest = simpleInterest;
        }

        [HttpPost("simpleInterest")]
        public IActionResult SimpleInterest(SimpleInterestParameters parameters)
        {
            double rate = parameters.rate;
            double amount = parameters.principleAmount;
            double year = parameters.year;
            int den = parameters.denominator;

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
