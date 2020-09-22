using HoneywellPOC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly Maths _maths;
        public OperationsController(Maths maths)
        {
            _maths = maths;
        }



        [HttpPost("add")]
        public IActionResult Add(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = _maths.Add(a, b)
            };
            return Ok(result);
        }

        [HttpPost("substract")]
        public IActionResult Substract(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = _maths.Substract(a, b)
            };
            
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = _maths.Multiply(a, b)
            };
            return Ok(result);
        }

        [HttpPost("divide")]
        public IActionResult Divide(double a, int b)
        {
            if (a == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = _maths.Divide(a, b)
            };
            return Ok(result);
        }
    }
}
