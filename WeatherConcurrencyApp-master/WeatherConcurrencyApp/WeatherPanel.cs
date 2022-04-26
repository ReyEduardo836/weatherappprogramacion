using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {
        OpenWeather openWeather;
        public WeatherPanel(OpenWeather openWeather)
        {
            InitializeComponent();
            this.openWeather = openWeather;
            this.lblCity.Text = openWeather.Name;
            this.lblTemperature.Text = openWeather.Main.Temp.ToString();
            this.lblWeather.Text = openWeather.Weather[0].Description;
        }
    }
}
