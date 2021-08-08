public class Builder 
{
    private string Name;
    private bool Parking;
    private bool Pool;

    public Builder(string name)
    {
        Name = name;
    }

    public Builder WithParking()
    {
        Parking = true;
        return this;
    }

    public Builder WithPool()
    {
        Pool = true;
        return this;
    }

    public Home Build()
    {
        return new Home(Name, Parking, Pool);
    }

}