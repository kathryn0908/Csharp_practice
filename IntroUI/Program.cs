using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            Console.WriteLine($"{p.FirstName} {p.LastName}");
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("This is a test");
        }
    }
}
