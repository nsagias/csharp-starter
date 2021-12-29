using System;
using System.Linq;
using System.Collections.Generic;

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
          Console.WriteLine(myNums.Min());
          Console.WriteLine(myNums.Sum());

          // declaring arrays
          string[] cars2 = new string[4];
          string[] cars3 = new string[4] {"Porche", "Lambo", "Jag", "Tesla"};
          string[] cars4 = new string[]{"Porche", "Lambo", "Jag", "Tesla"};
          string[] cars5 = {"Porche", "Lambo", "Jag", "Tesla"};

          var myArray = new[] {
            new {name = "nick", favouriteColor = "blue"},
            new {name = "dingo", favouriteColor = "any"},
          };
          var apple = new { item = "apples"};

          Console.WriteLine($"myArray: {myArray}");
          Console.WriteLine($"myArray: {apple.item}");


          List<int> numList = new List<int>() {1,2,3,4,5,6,7,8,9,10};

          foreach( int num in numList) {
            Console.WriteLine(num);
          }
          
    
          string setence = "I love salsa, mambo, and bachata";
          // notes only use double quotes in code
          string setence2 = setence.Replace(",", "");
          Console.WriteLine(setence2); // prints System.String[]
          string[] wordsFromSentenceList = setence2.Split(" ");
          Console.WriteLine(wordsFromSentenceList);
          foreach ( string word in wordsFromSentenceList) {
            Console.WriteLine(word);
          }       
          Console.WriteLine($"first item in numList {numList[0]}");
          Console.WriteLine($"frist item in wordsFromSetenceList {wordsFromSentenceList[0]}");

          Console.WriteLine("-----------------------------");

          //Fizz Buzz
          foreach( int num in numList) {
            if( num == 1 ) {
              Console.WriteLine("Numbers is 1");
            }
            if((num % 2 == 0) && (num % 3 == 0)){
              Console.WriteLine($"FizzBuzz {num}");
            } else if( num % 2 == 0) {
              Console.WriteLine($"Fizz {num}");
            } else if( num % 3 == 0) {
              Console.WriteLine($"Buzz {num}");
            } else { 
              Console.WriteLine($"Numbers is {num} and cannot be any");
            } 
          }
          

        }
    }
}
