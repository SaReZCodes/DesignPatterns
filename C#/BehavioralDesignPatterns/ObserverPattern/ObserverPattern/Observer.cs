using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Observer
    {
        protected Observable observable;
        public abstract void Update();
    }
}
