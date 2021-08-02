using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            Lumia1020 l = new Lumia1020();
            d.Construct(l);
            Console.WriteLine(l.Phone.ToString());

        }
    }
}
