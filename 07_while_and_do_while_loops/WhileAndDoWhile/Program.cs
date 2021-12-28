using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int numLoopLimit = 5;

            while (num1 <= numLoopLimit)
            {
              Console.WriteLine(num1);
              num1++;
            }

            do {
              Console.WriteLine(num2);
              num2++;
            }
            while (num2 < numLoopLimit);
        }
    }
}
