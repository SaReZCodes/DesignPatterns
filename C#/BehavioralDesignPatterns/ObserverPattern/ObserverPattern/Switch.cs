using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Switch : Observable
    {
        private bool _state;
        public bool ChangeState
        {
            set
            {
                _state = value;
                NotifyAllObservers();
            }
            get { return _state; }
        }
    }
}
