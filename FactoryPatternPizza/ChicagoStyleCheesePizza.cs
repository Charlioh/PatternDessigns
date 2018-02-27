using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class ChicagoSteelCheesePizza : Pizza
    {
        public ChicagoSteelCheesePizza()
        {
            Toppings = new List<string>();
            Name = "Chicago Style Sauce and Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Marina Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}