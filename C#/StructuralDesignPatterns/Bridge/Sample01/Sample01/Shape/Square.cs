using Sample01.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.Shape
{
    public class Square : Shape
    {
        public Square(IColor color)
           : base(color)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Square");
            _color.FillColor();
        }
    }
}
