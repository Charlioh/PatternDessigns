using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }


        public void Prepare()
        {
            Console.WriteLine("Prepareing " + Name);
            Console.WriteLine("Tossing dough " + Dough);
            Console.WriteLine("Adding Sauce " + Sauce);
            Console.WriteLine("Adding Toppings ");
            foreach (var Topping in Toppings)
            {
                Console.WriteLine("- " + Topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350º");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in a official PizzaStore Box");
        }

        
    }
}
