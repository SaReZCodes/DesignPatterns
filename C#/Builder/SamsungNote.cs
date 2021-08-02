public class SamsungNote : IBuilder
{
    public SamsungNote()
    {
        _Phone = new Phone("Samsung Note 8 ");
    }
    public Phone _Phone = null;
    public Phone Phone => _Phone;
    public void BuildScreen()
    {
        _Phone.Screen = "2960 x 1440 pixels";
    }
    public void BuildOs()
    {
        _Phone.OsName = "Android 9";
    }

}