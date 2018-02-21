namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(decimal temp, decimal humidity, decimal pressure);
    }
}
