public class Home
{
    public Home(string title, bool parking, bool pool)
    {
        Title = title;
        Parking = parking;
        Pool = pool;
    }

    public string Title { get; set; }
    public bool Parking { get; set; }
    public bool Pool { get; set; }
}