using System;

namespace LogicControlFlow
{
    class Program
  {
      static void Main(string[] args)
      {
        int num1 = 1;
        int num2 = 2;
        if (num1 < num2) 
        {
          Console.WriteLine("num1 is less than num2");
        } 
        else if (num1 > num2) 
        {
          Console.WriteLine("num1 is less than num2");
        }
        else if (num1 == num2) 
        {
          Console.WriteLine("there are the same");
        }
        else 
        {
          Console.WriteLine("somethings smells");
        }

      }
  }
}
