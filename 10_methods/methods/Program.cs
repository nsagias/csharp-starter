using System;

namespace methods {
  class Program {
    static void PrintName() {
      Console.WriteLine("Standard PrintName");
    }
    static void LamdaPrintName() => Console.WriteLine("Lambda PrintName");
    static void PrintNumber(int num) => Console.WriteLine($"{num}");

    
    static void Main(string[] args) {
      PrintName();
      LamdaPrintName();
      PrintNumber(1);
    }
  }
}
