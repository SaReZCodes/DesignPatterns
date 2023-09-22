using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IAirTrafficControl
    {
        void AddAirplanes(params AirplaneBase[] airplanes);

        void SendMessage(string message, AirplaneBase messageProducerAirplane);
    }
}
