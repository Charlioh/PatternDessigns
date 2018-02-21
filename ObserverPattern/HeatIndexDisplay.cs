using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class HeatIndexDisplay : IDisplayElement, IObserver
    {
        private decimal Index;
        private ISubject WeatherData;

        public HeatIndexDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current Heat Index: " + this.Index);
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            this.Index = ComputeHeatIndex(temp, humidity);
            Display();
        }


        private decimal ComputeHeatIndex(decimal t, decimal rh)
        {
            var index = ((16.923m + (0.185212m * t) + (5.37941m * rh) - (0.100254m * t * rh) +
                (0.00941695m * (t * t)) + (0.00728898m * (rh * rh)) +
                (0.000345372m * (t * t * rh)) - (0.000814971m * (t * rh * rh)) +
                (0.0000102102m * (t * t * rh * rh)) - (0.000038646m * (t * t * t)) + (0.0000291583m *
                (rh * rh * rh)) + (0.00000142721m * (t * t * t * rh)) +
                (0.000000197483m * (t * rh * rh * rh)) - (0.0000000218429m * (t * t * t * rh * rh)) +
                0.000000000843296m * (t * t * rh * rh * rh)) -
                (0.0000000000481975m* (t * t * t * rh * rh * rh)));
            return index;
        }
    }
}
