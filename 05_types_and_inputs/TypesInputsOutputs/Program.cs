using System;

namespace TypesInputsOutputs
{
    class Program
    {
        static void Main(string[] args)
        {
          // Plan create prompts from yours
          // Obtain data and convet types
          // Console.log types

          // name age salary
          // add boolean
          string name;
          int age;
          double salary;
          bool fun;
          char worksHard;

          Console.Write("Enter your name: ");
          name = Console.ReadLine();
          Console.Write("Enter your age: ");
          age = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter your salary: ");
          salary = Convert.ToDouble(Console.ReadLine());
          Console.Write("Are you fun? (true or false): ");
          fun = Convert.ToBoolean(Console.ReadLine());
          Console.Write("Do you work hard? (Y or N): ");
          worksHard = Convert.ToChar(Console.ReadLine());

        }
    }
}
