using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternSample2
{
    public class ConcrateColleague2 : Colleague
    {
        public ConcrateColleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine( message + nameof(ConcrateColleague2));
        }

        public override void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }
    }
}
