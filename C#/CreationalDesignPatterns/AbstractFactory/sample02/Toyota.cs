using System;

public class Toyota : ICarFactory
{
    public IDiesel GetDiesel()
    {
        return new Prado();
    }
    public IMotor GetMotor()
    {
        return new LandCruiser();
    }
}