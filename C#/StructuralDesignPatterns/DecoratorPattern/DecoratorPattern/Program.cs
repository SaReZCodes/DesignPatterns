using DecoratorPattern;
using DecoratorPattern.ConcrateComponnts;
using DecoratorPattern.ConcrateDecorators;

Beverage beverage1 = new Espresso();
Console.WriteLine(beverage1.Description);
Console.WriteLine(beverage1.Cost());

Beverage beverage2 = new Mocha(new Soy(new Espresso()));
Console.WriteLine(beverage2.Description);
Console.WriteLine(beverage2.Cost());

Console.ReadKey();