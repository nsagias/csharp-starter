using System;
using System.Linq;

namespace arraysExamples
{
    class Program
    {
        static void Main(string[] args)
        { 
          // array of strings
          string[] cars = {"Porche", "Lambo", "Jag", "Tesla"};

          // array of numbers
          int[] myNums = {10, 40, 30, 20};

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

          // use foreach to loop through each element 
          foreach (string car in cars) 
          {
            Console.WriteLine(car);
          }


          // Sort the use foreach
          Array.Sort(cars);
          foreach (string car in cars) 
          {
            Console.WriteLine(car);
          }

          Array.Sort(myNums);
          foreach (int i in myNums) 
          {
            Console.WriteLine(i);
          }

          Console.WriteLine(myNums.Max());
        }
    }
}
