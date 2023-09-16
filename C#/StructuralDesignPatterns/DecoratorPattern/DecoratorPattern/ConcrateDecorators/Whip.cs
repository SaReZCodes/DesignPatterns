﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateDecorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
           : base(beverage)
        {
            this.description = beverage.Description + ", " + nameof(Whip);
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.3;
        }
    }
}
