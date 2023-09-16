﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateComponnts
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend Coffee";
        }

        public override double Cost()
        {
            return 0.1;
        }
    }
}
