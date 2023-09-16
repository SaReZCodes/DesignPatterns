using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcrateDecorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
           : base(beverage)
        {
            this.description = beverage.Description + ", " + nameof(Soy);
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }
    }
}
