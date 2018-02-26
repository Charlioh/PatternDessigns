using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class CommodityChangeEventArgs : EventArgs
    {
        public Commodity Commodity { get; set; }

        public CommodityChangeEventArgs(Commodity commodity)
        {
            this.Commodity = commodity;
        }
    }
}
