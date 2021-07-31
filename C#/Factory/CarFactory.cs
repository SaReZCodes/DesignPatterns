public class CarFactory
{
    public ICarSupplier GetCar(CarType carType)
    {
        switch (carType)
        {
            case CarType.Benz:
                return new Benz();
            case CarType.Bmw:
                return new Bmw();
            case CarType.Peugeot:
                return new Peugeot();
            default: throw new System.Exception("Car Type Not Found");
        }
    }

    public enum CarType
    {
        Benz,
        Bmw,
        Peugeot
    }
}