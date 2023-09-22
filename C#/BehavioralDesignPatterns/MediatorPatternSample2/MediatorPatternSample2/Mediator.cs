using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternSample2
{
    public abstract class Mediator
    {
        public abstract void SendMessage(string message, Colleague colleague);
    }
}
