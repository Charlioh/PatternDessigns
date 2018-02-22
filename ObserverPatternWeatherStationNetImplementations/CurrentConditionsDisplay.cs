using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherStationNetImplementations
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {


        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            throw new NotImplementedException();
        }
    }
}
