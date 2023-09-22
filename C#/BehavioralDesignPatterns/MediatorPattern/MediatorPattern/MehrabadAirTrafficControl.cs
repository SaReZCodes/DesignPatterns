using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class MehrabadAirTrafficControl : IAirTrafficControl
    {
        readonly List<AirplaneBase> _airplanes = new List<AirplaneBase>();

        public void AddAirplanes(params AirplaneBase[] airplanes)
        {
            _airplanes.AddRange(airplanes);
        }

        public void SendMessage(string message, AirplaneBase messageProducerAirplane)
        {
            List<AirplaneBase> otherAirplanes = _airplanes
                .Where(airplane => airplane != messageProducerAirplane)
                .ToList();

            otherAirplanes.ForEach(airplane => airplane.Notify(message));
        }
    }
}
