using System;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numLoopLimit = 5;
            while (num <= numLoopLimit)
            {
              Console.WriteLine(num);
              num++;
            }
        }
    }
}
