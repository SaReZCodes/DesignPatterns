public class Lumia1020 : IBuilder
{
    Phone _Phone = null;
    public Lumia1020()
    {
        _Phone = new Phone("Lumia1020 ");
    }
    public Phone Phone => _Phone;
    public void BuildScreen()
    {
        _Phone.Screen = "768x1280 pixels";
    }
    public void BuildOs()
    {
        _Phone.OsName = "Windows Phone 8 ";
    }

}