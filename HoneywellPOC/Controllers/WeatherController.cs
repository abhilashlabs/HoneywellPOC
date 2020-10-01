using System;
using Microsoft.AspNetCore.Mvc;

namespace HoneywellPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        /// <summary>
        /// This is for dependency injection
        /// </summary>
        private readonly WeatherForecast _weather;
        /// <summary>
        /// Creation of constructor
        /// </summary>
        /// <param name="weather"></param>
        public WeatherController(WeatherForecast weather)
        {
            _weather = weather;
        }

        /// <summary>
        /// This is a http post method to get temperature for a city 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpPost("temperatureByCity")]
        public IActionResult TemperatureByCity(string city)
        {
            if (string.IsNullOrEmpty(city))
                return NoContent();

            //throw new NotImplementedException();

            var result = _weather.getTemperatureByCity(city);
            return Ok(result);

        }
    }
}
