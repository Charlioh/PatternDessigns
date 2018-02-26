using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunModernObserableBasedApproach();
            Console.ReadKey();
        }

        private static void RunNaiveExample()
        {
            IEnumerable<Commodity> commodities = new CommodityRepository().GetAllCommodities();
            foreach (Commodity commodity in commodities)
            {
                if (commodity.Name == "cocoa")
                {
                    Console.WriteLine("The current price of cocoa is {0}", commodity.Price);
                }

                if (commodity.Name == "milk" && commodity.Price > 2m)
                {
                    Console.WriteLine("The price of milk has now reached {0}", commodity.Price);
                }
            }
        }

        private static void RunEventBasedExample()
        {
            CommodityMonitor monitor = new CommodityMonitor();

            CocoaObserver cocoaObserver = new CocoaObserver(monitor);
            MilkObserver milkObserver = new MilkObserver(monitor);

            IEnumerable<Commodity> commodities = new CommodityRepository().GetAllCommodities();
            foreach (Commodity commodity in commodities)
            {
                monitor.Commodity = commodity;
            }
        }

        private static void RunModernObserableBasedApproach()
        {
            ObservableCommodity oc = new ObservableCommodity();
            MilkObserverModern milkObserver = new MilkObserverModern();
            CocoaObserverModern cocoaObserver = new CocoaObserverModern();
            IEnumerable<Commodity> commodities = new CommodityRepository().GetAllCommodities();
            using (oc.Subscribe(milkObserver))
            {
                using (oc.Subscribe(cocoaObserver))
                {
                    foreach (Commodity commodity in commodities)
                    {
                        oc.Commodity = commodity;
                    }
                }
            }
        }
    }
}
