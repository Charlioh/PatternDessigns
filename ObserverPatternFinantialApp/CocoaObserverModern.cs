using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class CocoaObserverModern : IObserver<Commodity>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Shop closed.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Oops: {0}", error.Message);
        }

        public void OnNext(Commodity commodity)
        {
            if (commodity.Name == "cocoa")
            {
                Console.WriteLine("The current price of cocoa is {0}", commodity.Price);
            }
        }
    }
}
