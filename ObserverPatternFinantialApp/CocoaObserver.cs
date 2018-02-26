using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class CocoaObserver
    {
        public CocoaObserver(CommodityMonitor monitor)
        {
            monitor.CommodityChange += monitor_CommodityChange;
        }

        void monitor_CommodityChange(object sender, CommodityChangeEventArgs e)
        {
            CheckFilter(e.Commodity);
        }

        private void CheckFilter(Commodity commodity)
        {
            if (commodity.Name == "cocoa")
            {
                Console.WriteLine("The current price of cocoa is {0}", commodity.Price);
            }
        }
    }
}
