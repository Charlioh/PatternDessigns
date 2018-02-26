using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class ObservableCommodity : IObservable<Commodity>
    {
        private List<IObserver<Commodity>> _observers = new List<IObserver<Commodity>>();
        private Commodity _commodity;
        public Commodity Commodity
        {
            get
            {
                return _commodity;
            }
            set
            {
                _commodity = value;
                this.Notify(_commodity);
            }
        }

        private void Notify(Commodity commodity)
        {
            foreach (IObserver<Commodity> observer in _observers)
            {
                if (commodity.Name == null || commodity.Price < 0)
                {
                    observer.OnError(new Exception("Bad Commodity data"));
                }
                else
                {
                    observer.OnNext(commodity);
                }
            }
        }

        private void Stop()
        {
            foreach (IObserver<Commodity> observer in _observers)
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }
            _observers.Clear();
        }


        public IDisposable Subscribe(IObserver<Commodity> observer)
        {
            if (!_observers.Contains(observer)) 
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Commodity>> _observers;
            private IObserver<Commodity> _observer;

            public Unsubscriber(List<IObserver<Commodity>> observers, IObserver<Commodity> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}
