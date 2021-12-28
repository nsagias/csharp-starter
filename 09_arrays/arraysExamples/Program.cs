using System;

namespace arraysExamples
{
    class Program
    {
        static void Main(string[] args)
        { 
          // array of strings
          string[] cars = {"Porche", "Lambo", "Jag", "Tesla"};

          // array of numbers
          int[] myNums = {10, 20, 30, 40};

          // print first element in array
          Console.WriteLine(cars[0]);

          // change value of first element and print
          cars[0] = "Ferrari";
          Console.WriteLine(cars[0]);

          // print length of array
          Console.WriteLine(cars.Length);

          // loop through array using car.length value
          for (int i = 0; i < cars.Length; i++) 
          {
            Console.WriteLine(cars[i]);
          }
        }
    }
}
