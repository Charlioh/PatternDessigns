using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() : base()
        {
            description = "DarkRoast";
        }
        public override decimal Cost()
        {
            return 0.99m;
        }
    }
}
