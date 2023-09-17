using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        public static IDictionary<string, IShape> Shapes = new Dictionary<string, IShape>();

        public IShape GetShape()
        {
            if (Shapes.Any(x => x.Key == "Circle"))
                return Shapes["Circle"];
            else
            {
                var shape = new Circle();
                Shapes.Add("Circle",shape);
                Console.WriteLine("Crate New Object");
                return shape;
            }

        }

    }
}
