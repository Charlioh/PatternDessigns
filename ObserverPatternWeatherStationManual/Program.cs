using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherStationManual
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            CurrentPressureDisplay currentPressureDisplay = new CurrentPressureDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4m);
            weatherData.SetMeasurements(82, 70, 29.2m);
            weatherData.SetMeasurements(78, 90, 29.2m);
            Console.ReadLine();
        }
    }
}
