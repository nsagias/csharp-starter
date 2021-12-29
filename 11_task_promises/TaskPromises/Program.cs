using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace TaskPromises
{
    class Program
    {

    
       static void Main(string[] args)
        {
            Console.WriteLine("Task and Promisses poissibly async");
            Console.WriteLine(DateTime.Now);
            AsyncMethod();
            AsyncMethod2();
            Console.ReadKey();

        }
          public static async Task AsyncMethod(){
            await Task.Run(() => {
              for (int i = 0; i < 100; i++){
                Console.WriteLine($"Ansyc Method {DateTime.Now}");
                Task.Delay(100).Wait();
              }
          });
        }
          public static async Task AsyncMethod2(){
            await Task.Run(() => {
              for (int i = 0; i < 10; i++){
                Console.WriteLine($"Ansyc Method 2 {DateTime.Now}");
                Task.Delay(100).Wait();
              }
            });
          }

        
    }
}
