using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Your name is: ");
            Console.WriteLine(name);
        }
    }
}
