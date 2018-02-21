using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private decimal Temp;
        private decimal Humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current weather conditiones are {0} ºC and {1} humidity",Temp,Humidity);
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            Display();
        }
    }
}
