﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateComponnts
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 2;
        }
    }
}
