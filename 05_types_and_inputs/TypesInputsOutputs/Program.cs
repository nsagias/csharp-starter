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
          
          // string firstName = "Nick";
          // string firstName2 = "Nick";
          // string lastName = "NotNick";
          // // returns -1 or 0
          // int result = string.Compare(firstName, lastName); // length compare
          // int result2 = string.Compare(firstName, firstName); // length compare
          // Console.WriteLine(result);
          // Console.WriteLine(result);
          
          // Console.WriteLine(firstName.Length); // get firstname length
          // Console.WriteLine(firstName == firstName2); // return true or false 

          try {
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
      
          // Create console output

           Console.WriteLine($"This is my console profile my name is {name} my age {age} I make this much {salary} it is true I am {fun}  do I work hard {worksHard}");
          } catch  (Exception e) {
            Console.WriteLine($"Error: Something went wrong {e.Message}");
          } finally {
            Console.WriteLine("finally....");
          }

        }
    }
}
