﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Light 
    {
        public void On()
        {
            Console.WriteLine("Light On");
        }

        public void Off()
        {
            Console.WriteLine("Light Off");
        }
    }
}
