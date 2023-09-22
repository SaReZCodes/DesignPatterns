using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class AirplaneBase
    {
        protected readonly IAirTrafficControl AirTrafficControl;

        public AirplaneBase(IAirTrafficControl airTrafficControl)
        {
            AirTrafficControl = airTrafficControl;
        }

        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
}
