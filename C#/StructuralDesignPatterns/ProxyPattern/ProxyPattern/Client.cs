using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Client
    {
        public void DoAction(IISP subject)
        {
            Console.WriteLine(subject.GetResource("www.yahoo.com"));
            Console.WriteLine(subject.GetResource("www.google.com"));
        }
    }
}
