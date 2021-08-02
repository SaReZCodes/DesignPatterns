public class Director
{
    public void Construct(IBuilder builder)
    {
       builder.BuildOs();
       builder.BuildScreen();
    }
}