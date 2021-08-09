using static System.Console;
public class Client
{
    ICarFactory _carFactory;
    public void SetFactory(ICarFactory carFactory)
    {
        _carFactory = carFactory;
    }

    public void CreateCars()
    {
        var car1 = _carFactory.GetDiesel();
        var car2 = _carFactory.GetMotor();
        WriteLine(car1.GetName());
        WriteLine(car2.GetName());
    }
}