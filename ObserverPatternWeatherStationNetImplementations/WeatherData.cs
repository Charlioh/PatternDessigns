using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherStationNetImplementations
{
    public class WeatherData
    {
        private decimal Temperature { get; set; }
        private decimal HumidityValue { get; set; }
        private decimal Pressure { get; set; }

        public void SetValues(decimal temp, decimal hum, decimal pres)
        {
            Temperature = temp;
            HumidityValue = hum;
            Pressure = pres;
        }


    }
}
