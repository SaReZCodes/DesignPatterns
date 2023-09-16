using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateComponnts
{
    public class DarkRoast : Beverage
    {

        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double Cost()
        {
            return 1;
        }
    }
}
