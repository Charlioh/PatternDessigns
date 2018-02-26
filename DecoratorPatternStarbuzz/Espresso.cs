using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzz
{
    public class Espresso : Beverage
    {
        public Espresso() : base()
        {
            description = "Espresso";
        }
        public override decimal Cost()
        {
            return 1.99m;
        }
    }
}
