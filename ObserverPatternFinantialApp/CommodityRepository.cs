using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternFinantialApp
{
    public class CommodityRepository
    {
        public IEnumerable<Commodity> GetAllCommodities()
        {
            return new List<Commodity>()
            {
                new Commodity(){Name = "milk", Price= 1}
                , new Commodity() {Name = "milk", Price = 1.2m}
                , new Commodity() {Name = "milk", Price = 1.3m}
                , new Commodity() {Name = "cocoa", Price = 2.1m}
                , new Commodity() {Name = "milk", Price = 3.2m}
                , new Commodity() {Name = "cocoa", Price = 2.9m}
                , new Commodity() {Name = "milk", Price = 1.8m}
                , new Commodity() {Name = "cocoa", Price = 1.7m}
            };
        }
    }
}
