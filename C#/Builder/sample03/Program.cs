using System;

namespace sample03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new PersonBuilder().Id(1)
            .Name("Saeed")
            .Family("Rezaei")
            .Age(32)
            .Build();

            Console.WriteLine(" my name is :{0} {1} I am {2} years old"
                                      , person.Name, person.Family, person.Age);
        }
    }
}
