public class Phone
{
    public Phone(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public string OsName { get; set; }
    public string Screen { get; set; }

    public override string ToString()
    {
        return string.Format("{0} / {1} / {2}", Name, OsName, Screen);
    }
}