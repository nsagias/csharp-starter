using System;

namespace classes
{
    class Program {
      static void Main(string[] args) {
        int num = 0;

        Box box = new Box();
        box.Length = 10;
        box.Width = 15;
        box.Height = 20;
        double volume = box.getVolume();
        
        try {
          Console.WriteLine($"{box.Length}, {box.Height}, {box.Width}");
          Console.WriteLine($"Box volume {volume}");
        } 
        catch (Exception e) {
          Console.WriteLine(e.Message);
        }
        finally {
          Console.WriteLine("Functions ended");
        }
        
      }
    }

}
