using System;

namespace DeepCloneBySerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Color = "red";
            car.Plate = "10B110";
            car.Model = new CarModel { Name = "320", FactoryName = "Benz" };

            var newCar = car.DeepCopy();

            Console.WriteLine(car.Model.FactoryName, car.Model.Name);
            Console.WriteLine(newCar.Model.FactoryName, newCar.Model.Name);

            newCar.Model.FactoryName = "BMW";
            newCar.Model.Name = "X6";

            Console.WriteLine("After change NewCar Model");
            Console.WriteLine(car.Model.FactoryName, car.Model.Name);
            Console.WriteLine(newCar.Model.FactoryName, newCar.Model.Name);
            Console.ReadKey();
        }
    }
}
