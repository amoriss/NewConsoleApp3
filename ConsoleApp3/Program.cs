using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hello";
            int num = 3;
            char letter= 'R';
            bool yes = true;
            double price = 4.50;
            decimal n = 4.5m; 
            Console.WriteLine("Hello World!");
            Console.WriteLine($"My dog's name is {x}, He is {num} years old. His favorite letter \n" +
                              $"is {letter}. He loves his food, it's {yes}. His favorite toy costs {price} \n" +
                              $"and his collar is {n} feet long.");
        }
    }
}
