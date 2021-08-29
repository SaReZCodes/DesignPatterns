using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var mercedes = new Mercedes();
            client.SetFactory(mercedes);
            client.CreateCars();
            
            var toyota = new Toyota();
            client.SetFactory(toyota);
            client.CreateCars();
            
            Console.ReadKey();
        }
    }
}
