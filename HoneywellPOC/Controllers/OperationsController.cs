using System;
using HoneywellPOC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class OperationsController : ControllerBase
    {
        private readonly Maths _maths;
        public OperationsController(Maths maths)
        {
            _maths = maths;
        }

        [HttpPost("add")]
        public IActionResult Add(OperationsParameters parameters)
        {
            double a = parameters.a;
            double b = parameters.b;
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
        public IActionResult Subtract(OperationsParameters parameters)
        {
            double a = parameters.a;
            double b = parameters.b;
            if (a == 0 || b == 0)
                return NoContent();

            var result = new ApiResponse
            {
                status = "success",
                result = _maths.Subtract(a, b)
            };
            
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply(OperationsParameters parameters)
        {
            double a = parameters.a;
            double b = parameters.b;
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
        public IActionResult Divide(OperationsParameters parameters)
        {
            double a = parameters.a;
            int b = Convert.ToInt32(parameters.b);

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
