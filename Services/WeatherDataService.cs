using BasicWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWeatherApp.Services
{
    public class WeatherDataService
    {
        public CurrentWeatherData DeserializeCurrentWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<CurrentWeatherData>(json);
        }
    }
}
