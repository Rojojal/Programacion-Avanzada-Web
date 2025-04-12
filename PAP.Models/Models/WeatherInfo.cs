using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Models.Models
{
    public class WeatherInfo
    {
        public string City { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public string IconUrl { get; set; }
    }
}
