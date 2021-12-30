using System;

namespace classes
{
    class Program {
      static void Main(string[] args) {
        Box box = new Box();
        box.Length = 10;
        box.Width = 15;
        box.Height = 20;
        double volume = box.getVolume();

        Person person = new Person();
        try {
          person.FirstName = "Nick";
          person.LastName = "Sagias";
          person.setAge(10);
        } catch (Exception e) {
          Console.WriteLine(e.Message);
          
        } finally {
          Console.WriteLine("Finally: create person function");
        }
      
        
        // try {
        //   Console.WriteLine($"{box.Length}, {box.Height}, {box.Width}");
        //   Console.WriteLine($"Box volume {volume}");
        // } 
        // catch (Exception e) {
        //   Console.WriteLine(e.Message);
        // }
        // finally {
        //   Console.WriteLine("Functions ended");
        // }
        
      }
    }

}
