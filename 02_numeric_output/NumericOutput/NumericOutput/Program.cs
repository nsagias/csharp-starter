using System;

namespace NumericOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // output line to user
            Console.WriteLine(42);

            // do math in console
            Console.WriteLine(1 + 1);

            // do more math in console,
            // parenthesis priority
            Console.WriteLine(1 + 2 * 3);
            Console.WriteLine((1 + 2) * 3);

            //// console readline
            //Console.ReadLine();
        }
    }
}
