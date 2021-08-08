using System;

namespace Sample02
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder("Home With Pool & Parking");
            Director director = new Director(builder);
            director.Construct();
        }
    }
}
