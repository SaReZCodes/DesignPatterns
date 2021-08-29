public class Iphone6 : IBuilder
{
    Phone _Phone = null;
    public Iphone6()
    {
        _Phone = new Phone("Iphone6 ");
    }
    public Phone Phone => _Phone;
    public void BuildScreen()
    {
        _Phone.Screen = "768x1280 pixels";
    }
    public void BuildOs()
    {
        _Phone.OsName = "IOS 9 ";
    }

    public void Build()
    {
        _Phone.OsName = "IOS 9 ";
    }
}