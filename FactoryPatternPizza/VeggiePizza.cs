using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizza
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + GetName());
            Dough = _ingredientFactory.CreateDought();
            Sauce = _ingredientFactory.CreateSauce();
            Clams = _ingredientFactory.CreateClams();
        }
    }
}
