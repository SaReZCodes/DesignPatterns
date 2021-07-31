using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            ICarSupplier carSuppllier = carFactory.GetCar(CarFactory.CarType.Peugeot);
            carSuppllier.Start();

            carSuppllier= carFactory.GetCar(CarFactory.CarType.Benz);
            carSuppllier.Start();

            carSuppllier =carFactory.GetCar(CarFactory.CarType.Bmw);
            carSuppllier.Start();
        }
    }
}
