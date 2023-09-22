using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternSample2
{
    public class ConcrateColleague : Mediator
    {
        private Colleague _colleague1;
        private Colleague _colleague2;

        public Colleague Colleague1
        {
            set
            {
                _colleague1 = value;
            }
        }

        public Colleague Colleague2
        {
            set
            {
                _colleague2 = value;
            }
        }

        public override void SendMessage(string message, Colleague colleague)
        {
            if (_colleague1 == colleague)
                _colleague2.Notify(message);
            else
                _colleague1.Notify(message);

        }
    }
}
