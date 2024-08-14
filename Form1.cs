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

        private WeatherDataService _weatherDataService;

        public Form1()
        {
            InitializeComponent();
            _weatherDataService = new WeatherDataService();

            LoadCurrentWeatherData();
        }

        private void LoadCurrentWeatherData()
        {

        }
    }
}
