using System;
using System.Collections.Generic;

namespace ObserverPatternWeatherStationNetImplementations
{
    public class Unsubscriber<T> : IDisposable
    {
        public List<IObserver<T>> Subjects { get; set; }
        public IObserver<T> Subject { get; set; }

        public Unsubscriber(List<IObserver<T>> subjects, IObserver<T> subject )
        {
            Subjects = subjects;
            Subject = subject;
        }

        public void Dispose()
        {
            Subjects.Remove(Subject);
        }
    }
}