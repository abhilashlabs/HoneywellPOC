using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoneywellPOC.Business
{
    public interface IWeatherForecast
    {
        public dynamic getTemperatureByCity(string city);
    }
}
