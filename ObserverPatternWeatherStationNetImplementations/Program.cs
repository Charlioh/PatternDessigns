using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.lenntech.es/calculadoras/viento/sensacion-termica.htm

namespace ObserverPatternWeatherStationNetImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherSubject = new WeatherDataHandler();
            var displayer = new CurrentConditionsDisplay();

            weatherSubject.Subscribe(displayer);

            var weatherReader =  weatherSubject.NewReader();
            weatherReader.SetValues(80, 65, 30.4m);
            var weatherReader2 = weatherSubject.NewReader(10,10,10.2m);
            weatherReader.SetValues(82, 70, 29.2m);
            weatherReader.SetValues(78, 90, 29.2m);


        }
    }
}
