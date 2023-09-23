using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class GreenLED : Observer
    {
        private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"Green LED is {((_on) ? "On" : "Off")}");
        }
    }
}
