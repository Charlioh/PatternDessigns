using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ObserverPatternWeatherStationNetImplementations
{
    public class WeatherDataHandler : IObservable<WeatherData>
    {
        public List<IObserver<WeatherData>> Observers { get; set; }

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
    }
}
