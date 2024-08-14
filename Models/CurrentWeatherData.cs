using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Models
{
    public class CurrentWeatherData
    {
        public CurrentUnits current_units {  get; set; }
        public CurrentValues current {  get; set; }
    }
}
