using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza (string Item)
        {
            if (Item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (Item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (Item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (Item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;

        }
    }
}
