﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternStarbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
