using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public Pizza CreatePizza(string Item)
        {
            if (Item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (Item.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (Item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (Item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;

        }
    }
}
