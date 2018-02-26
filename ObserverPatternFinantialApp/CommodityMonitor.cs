using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class CommodityMonitor
    {
        private Commodity _commodity;
        public event EventHandler<CommodityChangeEventArgs> CommodityChange;

        public Commodity Commodity
        {
            get
            {
                return _commodity;
            }
            set
            {
                _commodity = value;
                this.OnCommodityChange(new CommodityChangeEventArgs(_commodity));
            }
        }

        protected virtual void OnCommodityChange(CommodityChangeEventArgs e)
        {
            if (CommodityChange != null)
            {
                CommodityChange(this, e);
            }
        }
    }
}
