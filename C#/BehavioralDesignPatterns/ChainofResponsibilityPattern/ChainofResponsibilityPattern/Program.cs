using ChainofResponsibilityPattern;

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);


Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.DoAction(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.DoAction(squirrel);