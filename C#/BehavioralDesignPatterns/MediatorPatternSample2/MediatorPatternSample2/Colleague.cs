using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternSample2
{
    public abstract class Colleague
    {
        protected readonly Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void SendMessage(string message);
        public abstract void Notify(string message);
    }
}
