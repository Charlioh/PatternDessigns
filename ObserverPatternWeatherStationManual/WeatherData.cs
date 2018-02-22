using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherStationManual
{
    public class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private decimal Temp;
        private decimal Humidity;
        private decimal Pressure;


        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }


        public void NotifyObservers()
        {
            foreach (var obs in Observers)
            {
                obs.Update(Temp, Humidity, Pressure);
            }
        }


        public decimal GetTemperature()
        {
            return this.Temp;
        }
        
        public decimal GetHumidity()
        {
            return this.Humidity;
        }

        public decimal GetPressure()
        {
            return this.Pressure;
        }

        public void MeasuremetsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(decimal temp, decimal humidity, decimal pressure)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasuremetsChanged();
        }

    }
}
