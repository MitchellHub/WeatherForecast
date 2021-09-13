using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Models
{
    public class OpenWeather
    {
        public Daily[] Daily { get; set; }
    }

    public class Daily
    {
        public long Dt { get; set; }
        public Temp Temp { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class Temp
    {
        private double min;
        public double Min
        {
            get { return min; }
            set { min = (value - 32) / 1.8; }
        }

        private double max { get; set; }
        public double Max
        {
            get { return max; }
            set { max = (value - 32) / 1.8; }
        }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
