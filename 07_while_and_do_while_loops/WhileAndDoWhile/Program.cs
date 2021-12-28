using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 5;
            int num4 = 5;
            int numLoopLimit = 5;
            int numLowerLimit = 0;

            Console.WriteLine("------------ START -------------");
            Console.WriteLine("--------------------------------");


            while (num1 <= numLoopLimit)
            {
              Console.WriteLine(num1);
              num1++;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

            do {
              Console.WriteLine(num2);
              num2++;
            }
            while (num2 < numLoopLimit);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");


            while (num3 >= numLowerLimit)
            {
              Console.WriteLine(num3);
              num3--;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

            do {
              Console.WriteLine(num4);
              num4--;
            }
            while (num4 >= numLowerLimit);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------ END ---------------");
        }
    }
}
