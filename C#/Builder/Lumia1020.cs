public class Lumia1020 : IBuilder
{
    public Lumia1020()
    {
        _Phone = new Phone("Lumia1020 ");
    }
    Phone _Phone = null;
    public Phone Phone => _Phone;
    public void BuildScreen()
    {
        _Phone.Screen = "768x1280 pixels";
    }
    public void BuildOs()
    {
        _Phone.OsName = "Windows Phone 8 ";
    }

    public void Build()
    {
        _Phone.OsName = "Windows Phone 8 ";
    }


}