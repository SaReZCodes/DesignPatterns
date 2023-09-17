using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Circle : IShape
    {
        public string Color { get; set; }
        private int Radius = 40;
        private int x = 20;
        private int y = 50;

        public void Draw()
        {
            Console.WriteLine($"Draw new {Color} Circle in X:{x},Y:{y}");
        }
    }
}
