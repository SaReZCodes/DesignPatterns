using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : IISP
    {
        private Vodafone _realSubject;

        public Proxy(Vodafone realSubject)
        {
            this._realSubject = realSubject;
        }

        public bool CheckAccess(string site)
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            if (site != "www.google.com")
                return false;
            return true;
        }

        public string GetResource(string site)
        {
            if (this.CheckAccess(site))
            {
                this.LogAccess();
                return this._realSubject.GetResource(site);
            }

            return "Access Denied";
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
