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
        int num3 = 3;
        int num4 = 4;


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

        
        result = (num3 < num4) ? 
          $"{num3} is lower than {num4}" 
          : $"{num4} is lower than {num3}";

        Console.WriteLine(result);


      }
  }
}
