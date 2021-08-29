using static System.Console;
public class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
      WriteLine("boil water ,pour {0} ml For Tea", amount);
      return new Tea();
    }
}