using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ObserverPatternWeatherStationNetImplementations
{
    public class WeatherDataHandler : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> Observers { get; set; }
        private List<WeatherData> Observables { get; set; }

        public WeatherDataHandler()
        {
            Observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }

            return new Unsubscriber<WeatherData>(Observers, observer);
        }

        public WeatherData NewReader()
        {
            var data =  new WeatherData();
            Observables.Add(data);
            return data;
        }

        public WeatherData NewReader(decimal temp, decimal hum, decimal pres)
        {
            var data = new WeatherData(temp, hum, pres);
            Observables.Add(data);
            return data;
        }

    }
}
