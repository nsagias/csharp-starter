using System;

namespace UsingVariables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string message;
            message = "any message will do";

            string anotherMessage;
            anotherMessage = "another any message will do";

            int number = -12;

            int sum = 1 + 1;
            Console.WriteLine(
                @"Show result with at sybol printout
====================================
one and one is: " + sum
            );
      

            Console.WriteLine($"message {message}");
            Console.WriteLine($"anotherMessage {anotherMessage}");

            Console.WriteLine("number " + number);
            Console.WriteLine($"number {number}");



        }
    }
}
