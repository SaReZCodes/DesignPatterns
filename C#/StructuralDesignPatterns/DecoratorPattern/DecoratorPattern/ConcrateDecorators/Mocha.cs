using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
           : base(beverage)
        {
            this.description =beverage.Description +  ", " + nameof(Mocha);
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.1;
        }
    }
}
