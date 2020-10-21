using System;
using System.ComponentModel.DataAnnotations;

namespace HoneywellPOC
{
    public class Response
    {
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm}")]
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string City { get; set; }
    }

}
