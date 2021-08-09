public class Mercedes : ICarFactory
{
    public IDiesel GetDiesel()
    {
        return new BenzGla();
    }
    public IMotor GetMotor()
    {
        return new BenzGls();
    }
}