using BasicWeatherApp.Models;
using BasicWeatherApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWeatherApp
{
    public partial class Form1 : Form
    {
        private string latitude = "-26.201450";
        private string longitude = "28.045490";

        private string siteUrl = "https://api.open-meteo.com/v1/forecast";

        private WeatherDataService _weatherDataService;

        public Form1()
        {
            InitializeComponent();
            _weatherDataService = new WeatherDataService();

            LoadCurrentWeatherData();
            LoadHourlyWeatherData();
            LoadDailyWeatherData();
        }

        private async void LoadCurrentWeatherData()
        {
            string currentData = "temperature_2m,weather_code,apparent_temperature,is_day,relative_humidity_2m,dew_point_2m,rain,wind_speed_10m,snowfall,visibility";
            string currentEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&current=" + currentData;

            string jsonString = await _weatherDataService.GetJsonString(siteUrl, currentEndpoint);

            CurrentWeatherData currentWeather = _weatherDataService.DeserializeCurrentWeatherData(jsonString);
            CurrentUnits currentUnits = currentWeather.current_units;
            CurrentValues currentValues = currentWeather.current;

            current_w_temp.Text = Math.Round(currentValues.temperature_2m) + " " + currentUnits.temperature_2m;

            apparent_temp.Text = "Feels Like " + Math.Round(currentValues.apparent_temperature) + " " + currentUnits.apparent_temperature;

            current_humidity.Text = Math.Round(currentValues.relative_humidity_2m) + " " + currentUnits.relative_humidity_2m;
            current_dew_point.Text = Math.Round(currentValues.dew_point_2m) + " " + currentUnits.dew_point_2m;
            current_rain.Text = Math.Round(currentValues.rain) + " " + currentUnits.rain;
            current_wind_speed.Text = Math.Round(currentValues.wind_speed_10m) + " " + currentUnits.wind_speed_10m;
            current_snowfall.Text = Math.Round(currentValues.snowfall) + " " + currentUnits.snowfall;
            current_visibility.Text = Math.Round(currentValues.visibility) + " " + currentUnits.visibility;

            Dictionary<string, string> weatherInfo = _weatherDataService.GetWeatherDescriptions(currentValues.weather_code, currentValues.is_day);

            current_w_image.Load(weatherInfo["image"]);
            current_w_desc.Text = weatherInfo["description"];
        }

        private async void LoadHourlyWeatherData()
        {
            string hourlyData = "temperature_2m,precipitation_probability,weather_code,wind_speed_10m,is_day";
            string hourlyEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&hourly=" + hourlyData;

            string jsonString = await _weatherDataService.GetJsonString(siteUrl, hourlyEndpoint);

            HourlyWeatherData hourlyWeatherData = _weatherDataService.DeserializeHourlyWeatherData(jsonString);

            HourlyUnits hourlyUnits = hourlyWeatherData.hourly_units;
            Hourly hourly = hourlyWeatherData.hourly;

            List<string> time = hourly.time;
            List<double> temperature = hourly.temperature_2m;
            List<double> rain = hourly.precipitation_probability;
            List<int> code = hourly.weather_code;
            List<double> wind = hourly.wind_speed_10m;
            List<int> isDay = hourly.is_day;

            DateTime now = DateTime.Now; //Get the current date and time
            string currentHourString = now.ToString("yyyy-MM-ddTHH:00");

            int startIndex = time.IndexOf(currentHourString);

            if(startIndex == -1)
            {
                MessageBox.Show("Current hour not found in the List");
                return;
            }

            int count = Math.Min(24, time.Count - startIndex);

            int _xPos = 0;

            for(int j = startIndex; j < startIndex + count; j++)
            {
                Dictionary<string, string> weatherInfo = _weatherDataService.GetWeatherDescriptions(code.ElementAt(j), isDay.ElementAt(j));

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 1;
                tableLayoutPanel.RowCount = 6;
                tableLayoutPanel.Size = new Size(150, 235);
                tableLayoutPanel.Location = new Point(_xPos, 10);

                for(int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle());
                }

                for(int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    if(i == 1)
                    {
                        tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel.RowStyles[i].Height = 100;
                    }
                    else if(i == 0 || i == 2)
                    {
                        tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel.RowStyles[i].Height = 30;
                    }
                    else
                    {
                        tableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                        tableLayoutPanel.RowStyles[i].Height = 25;
                    }
                }

                Label timeLabel = new Label();
                timeLabel.Text = time.ElementAt(j).Split('T')[1];
                timeLabel.Font = new Font("Arial", 10);
                timeLabel.ForeColor = Color.White;
                timeLabel.Margin = new Padding(3, 0, 3, 0);
                timeLabel.Dock = DockStyle.Fill;
                timeLabel.TextAlign = ContentAlignment.MiddleCenter;

                PictureBox imageBox = new PictureBox();
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                imageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                imageBox.Margin = new Padding(20, 15, 0, 0);
                imageBox.Load(weatherInfo["image"]);

                Label tempLabel = new Label();
                tempLabel.Text = Math.Round(temperature.ElementAt(j)) + " " + hourlyUnits.temperature_2m;
                tempLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                tempLabel.Margin = new Padding(0, 3, 0, 3);
                tempLabel.ForeColor = Color.White;
                tempLabel.Dock = DockStyle.Fill;
                tempLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = weatherInfo["description"];
                descriptionLabel.Font = new Font("Arial", 12);
                descriptionLabel.Margin = new Padding(0, 3, 0, 3);
                descriptionLabel.ForeColor = Color.White;
                descriptionLabel.Dock = DockStyle.Fill;
                descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label rainLabel = new Label();
                rainLabel.Text = "Rain - " + Math.Round(rain.ElementAt(j)) + " " + hourlyUnits.precipitation_probability;
                rainLabel.Font = new Font("Arial", 8);
                rainLabel.Margin = new Padding(0, 3, 0, 3);
                rainLabel.ForeColor = Color.White;
                rainLabel.Dock = DockStyle.Fill;
                rainLabel.TextAlign = ContentAlignment.MiddleCenter;


                Label windSpeedLabel = new Label();
                windSpeedLabel.Text = "Wind Speed - " + Math.Round(wind.ElementAt(j)) + " " + hourlyUnits.wind_speed_10m;
                windSpeedLabel.Font = new Font("Arial", 9);
                windSpeedLabel.Margin = new Padding(0, 3, 0, 3);
                windSpeedLabel.ForeColor = Color.White;
                windSpeedLabel.Dock = DockStyle.Fill;
                windSpeedLabel.TextAlign = ContentAlignment.TopCenter;

                tableLayoutPanel.Controls.Add(timeLabel, 0, 0);
                tableLayoutPanel.Controls.Add(imageBox, 0, 1);
                tableLayoutPanel.Controls.Add(tempLabel, 0, 2);
                tableLayoutPanel.Controls.Add(descriptionLabel, 0, 3);
                tableLayoutPanel.Controls.Add(rainLabel, 0, 4);
                tableLayoutPanel.Controls.Add(windSpeedLabel, 0, 5);

                hourly_panel.Controls.Add(tableLayoutPanel);

                _xPos += 156;

            }
            
        }

        private async void LoadDailyWeatherData()
        {
            string dailyData = "weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max";

            string dailyEndpoint = "?latitude=" + latitude + "&longitude=" + longitude + "&daily=" + dailyData;

            string jsonString = await _weatherDataService.GetJsonString(siteUrl, dailyEndpoint);
           

        }
    }
}
