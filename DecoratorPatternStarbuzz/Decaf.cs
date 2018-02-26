using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override decimal Cost()
        {
            return 1.05m;
        }
    }
}
