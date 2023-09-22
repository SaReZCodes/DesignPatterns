using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternSample2
{
    public class ConcrateColleague1 : Colleague
    {
        public ConcrateColleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine(message + nameof(ConcrateColleague1));
        }

        public override void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }
    }
}
