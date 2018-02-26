using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract decimal Cost();
    }
}
