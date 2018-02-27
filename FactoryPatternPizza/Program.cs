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
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore ChicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.CreatePizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name);

            pizza = ChicagoStore.CreatePizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name);

        }
    }
}
