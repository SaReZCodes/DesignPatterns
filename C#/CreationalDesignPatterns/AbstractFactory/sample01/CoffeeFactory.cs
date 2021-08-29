using static System.Console;
public class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteLine("boil water ,pour {0} ml fro Coffee", amount);
        return new Coffee();
    }
}
