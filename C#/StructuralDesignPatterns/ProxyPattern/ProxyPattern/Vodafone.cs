using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Vodafone : IISP
    {
        public string GetResource(string site)
        {
            switch (site)
            {
                case "www.yahoo.com":
                    return "yahoo";
                case "www.google.com":
                    return "google";
                default:
                    return "nt found";
            }
        }
    }
}
