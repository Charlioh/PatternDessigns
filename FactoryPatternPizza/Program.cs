using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore NyPizzaStore = new NYPizzaStore();

            NyPizzaStore.OrderPizza("cheese");
        }
    }
}
