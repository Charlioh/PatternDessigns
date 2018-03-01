using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public abstract class Pizza
    {
        private string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperonni Pepperoni { get; set; }
        public Clams Clams { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350º");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in a official PizzaStore Box");
        }

        public void SetName (string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            // code to print pizza here
        }
    }
}
