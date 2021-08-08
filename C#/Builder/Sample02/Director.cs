public class Director
{
    private Builder _builder;
    public Director(Builder builder)
    {
        _builder = builder;
    }
    public void Construct()
    {
       _builder.WithParking().WithPool().Build();
    }

}