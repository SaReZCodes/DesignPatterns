using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        private readonly Subsystem1 _subsystem1;

        private readonly Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operationN();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operation2();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
}
