using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class MilkObserver
    {
        public MilkObserver(CommodityMonitor monitor)
        {
            monitor.CommodityChange += monitor_CommodityChange;
        }

        void monitor_CommodityChange(object sender, CommodityChangeEventArgs e)
        {
            CheckFilter(e.Commodity);
        }

        private void CheckFilter(Commodity commodity)
        {
            if (commodity.Name == "milk" && commodity.Price > 2m)
            {
                Console.WriteLine("The price of milk has now reached {0}", commodity.Price);
            }
        }
    }
}
