using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype a = new Prototype();
            a.Name = "saeed";
            a.Family = "rezaei";
            a.Token = new Token
            {
                Roles = "admin",
                UserName = "saeedr22"
            };

            Console.WriteLine(a.Name);
            Console.WriteLine(a.Family);
            Console.WriteLine(a.Token.Roles);
            Console.WriteLine(a.Token.UserName);
            Console.WriteLine("________________Class A_______________");

            Prototype b = a.Clone() as Prototype;
            b.Name = "Ali ";
            b.Family = "Joudi ";
            b.Token.Roles = "guest";
            b.Token.UserName = "user1";

            Console.WriteLine(b.Name);
            Console.WriteLine(b.Family);
            Console.WriteLine(b.Token.Roles);
            Console.WriteLine(b.Token.UserName);
            Console.WriteLine("________________Class B _______________");

            Console.WriteLine(a.Name);
            Console.WriteLine(a.Family);
            Console.WriteLine(a.Token.Roles);
            Console.WriteLine(a.Token.UserName);
            Console.WriteLine("________________Class A_______________");

            Prototype c = a.ObjectMemberwiseClone() as Prototype;
            
            c.Name = "Sina";
            c.Family = "Rezaei";
            c.Token.Roles = "guest,admin";
            c.Token.UserName = "sinar22";

            Console.WriteLine(c.Name);
            Console.WriteLine(c.Family);
            Console.WriteLine(c.Token.Roles);
            Console.WriteLine(c.Token.UserName);
            Console.WriteLine("________________Class C_______________");

            Console.WriteLine(a.Name);
            Console.WriteLine(a.Family);
            Console.WriteLine(a.Token.Roles);
            Console.WriteLine(a.Token.UserName);
            Console.WriteLine("________________Class A_______________");
        }
    }
}
