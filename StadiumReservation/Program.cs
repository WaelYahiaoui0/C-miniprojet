using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}