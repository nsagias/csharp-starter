using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 0; i < 5; i++) 
          {
            Console.WriteLine(i);
          }
           
          // even
          for (int i = 0; i < 5; i = i + 2) 
          {
            Console.WriteLine(i);
          }
          
          // decrement 
          for (int i = 10;  i > 0; i--) 
          {
            Console.WriteLine(i);
          }

          int breakLoop = 3;
          // break out of look example
          for (int i = 0; i < 10; i++) 
          {
            if (i == breakLoop) 
            {
              Console.WriteLine($"breaking out at {breakLoop}");
              break;
            }
            Console.WriteLine(i);
          }

          int skipNumber = 5;
          for (int i = 0; i < 10; i++) 
          {
            if (i == skipNumber) 
            {
              Console.WriteLine($"skipping {skipNumber}");
              continue;
            }
            Console.WriteLine(i);
          }



           
          // Create a array of strings
          // use foreach to loop through array
          string[]  cars = {"Ferrari", "Lambo", "Fiat", "Zoom"};
          foreach(string car in cars)
          {
            Console.WriteLine(car);
          }

        }

        
    }
}
