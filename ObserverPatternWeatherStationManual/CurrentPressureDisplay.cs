using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherStationManual
{
    public class CurrentPressureDisplay : IDisplayElement, IObserver
    {
        private decimal Pressure;
        private ISubject WeatherData;

        public CurrentPressureDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("The actual pressure is " + Pressure + " hPa");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            this.Pressure = pressure;
            Display();
        }

    }
}
