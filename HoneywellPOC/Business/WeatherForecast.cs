using System;
using HoneywellPOC.Business;

namespace HoneywellPOC
{
    public class WeatherForecast: IWeatherForecast
    {
        public virtual dynamic getTemperatureByCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return "error";
            }
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
