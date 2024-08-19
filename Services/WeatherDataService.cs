using BasicWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

        public HourlyWeatherData DeserializeHourlyWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<HourlyWeatherData>(json);
        }

        public DailyWeatherData DeserializeDailyWeatherData(string json)
        {
            return JsonConvert.DeserializeObject<DailyWeatherData>(json);
        }

        public async Task<string> GetJsonString(string siteUrl, string endPoint)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(siteUrl);
                
                HttpResponseMessage response = await client.GetAsync(endPoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                return "Could not retrieve JSON object";
            }
        }

        public Dictionary<string, string> GetWeatherDescriptions(double weather_code, int is_day)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            string jsonFilePath = "C:\\Users\\sbuth\\source\\repos\\BasicWeatherApp\\weather_descriptions.json";

            string jsonString = File.ReadAllText(jsonFilePath);

            WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(jsonString);

            string indexString = weather_code.ToString();

            if(forecast != null)
            {
                var forecastType = typeof(WeatherForecast);
                var dayNightProperty = forecastType.GetProperty($"Day{indexString}");

                DayNight dayNight = (DayNight)dayNightProperty.GetValue(forecast);

                if(dayNightProperty != null)
                {
                    if(dayNight != null)
                    {
                        if(is_day == 1)
                        {
                            info["description"] = dayNight.day.description;
                            info["image"] = dayNight.day.image;
                        }
                        else
                        {
                            info["description"] = dayNight.night.description;
                            info["image"] = dayNight.night.image;
                        }
                    }
                }
                else
                {
                    dayNightProperty = forecastType.GetProperty("Day0");
                    dayNight = (DayNight)dayNightProperty.GetValue(forecast);

                    if(is_day == 1)
                    {
                        info["description"] = dayNight.day.description;
                        info["image"] = dayNight.day.image;
                    }
                    else
                    {
                        info["description"] = dayNight.night.description;
                        info["image"] = dayNight.night.image;
                    }
                }
            }

            return info;

        }
    }
}
