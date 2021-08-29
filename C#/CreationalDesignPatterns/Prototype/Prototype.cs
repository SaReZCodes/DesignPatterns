using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Prototype : APrototype
    {
        public override object Clone()
        {
            Prototype Clone= this.MemberwiseClone() as Prototype;
            Clone.Token = new Token();
            return Clone;
        }

        public override object ObjectMemberwiseClone()
        {
            return this.MemberwiseClone() as APrototype;
        }
    }
}
