﻿using System;

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
