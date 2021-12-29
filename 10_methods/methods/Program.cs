using System;

namespace methods {
  class Program {
    static void PrintName() {
      Console.WriteLine("Standard PrintName");
    }
    static void LamdaPrintName() => Console.WriteLine("Lamda PrintName");
    static void PrintNumber(int num) => Console.WriteLine($"{num}");
    static void PrintText(string text, string name) => Console.WriteLine($"{text} {name}");
   
    static int ReturnNumber1() =>  1;

    static void LamdaReturnFunction() => Console.WriteLine(ReturnNumber1());
    
    static void Main(string[] args) {
      PrintName();
      LamdaPrintName();
      PrintNumber(1);
      PrintText("Hello from", "Nick");
      LamdaReturnFunction();

    }
  }
}
