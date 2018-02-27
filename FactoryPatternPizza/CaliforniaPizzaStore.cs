using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public Pizza CreatePizza(string Item)
        {
            if (Item.Equals("cheese"))
            {
                return new CaliforniaStyleCheesePizza();
            }
            else if (Item.Equals("veggie"))
            {
                return new CaliforniaStyleVeggiePizza();
            }
            else if (Item.Equals("clam"))
            {
                return new CaliforniaStyleClamPizza();
            }
            else if (Item.Equals("pepperoni"))
            {
                return new CaliforniaStylePepperoniPizza();
            }
            else return null;

        }
    }
}
