using System;
using HoneywellPOC.Business;

namespace HoneywellPOC
{
    public class WeatherForecast: IWeatherForecast
    {
        public Response getTemperatureByCity(string city)
        {
            var rng = new Random();
            return new Response
            {
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20, 55),
                City = city

            };
        }
    }

}
