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
    static void ReturnFunction() {
      Console.WriteLine( ReturnNumber1() );
    }

    // passing function as param
    
    public static int Method1(string input) {
       return 0;
    }
    
    public static bool FunctionThatRunsTheMethod (Func<string, int> varMethodName) {
      int i = varMethodName("string");
      return true;
    }

    public static bool CallTheMethod() {
      return FunctionThatRunsTheMethod(Method1);
    }
    static void PassMeFunction(string someText) {
      Console.WriteLine($"{someText}");
    }

    static void PassMeAString(Action<string> CallBack, string theText) {
      CallBack(theText);
    }
    


    static void Main(string[] args) {
      PrintName();
      LamdaPrintName();
      PrintNumber(1);
      PrintText("Hello from", "Nick");
      LamdaReturnFunction();
      ReturnFunction();
      CallTheMethod();
      PassMeAString(PassMeFunction, "hi");

    }
  }
}
