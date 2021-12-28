using System;

namespace LogicControlFlow
{
    class Program
  {
      static void Main(string[] args)
      {
        
        // if statement variables
        int num1 = 1;
        int num2 = 2;

        // switch statement variables
        string BINGO = "BINGO";
        string NOT_BINGO = "NOT_BINGO";
        string SOMEONE_ELSE_WON = "SOMEONE_ELSE_WON";
        string LULZ = "LULZ";
        string isBingo = LULZ;

        // ternary operator variable

        string result;

        // Logic Operators ( <, >, ==, >=, <=, != )
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

        // Switch statement
        switch(isBingo) 
        {
          case "BINGO":
            Console.WriteLine(BINGO);
            break;

          case "NOT_BINGO":
            Console.WriteLine(NOT_BINGO);
            break;
          default:
            Console.WriteLine(SOMEONE_ELSE_WON);
            break;
        }

        


      }
  }
}
