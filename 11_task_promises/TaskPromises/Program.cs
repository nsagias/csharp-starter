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

        }

         public static async Task AsyncMethod(){
            await Task.Run(() => {
              Console.WriteLine(DateTime.Now);
              for (int i = 0; i < 100; i++){
                Console.WriteLine($"Ansyc Method {DateTime.Now}");
                Task.Delay(100).Wait();
                
              }
              Console.WriteLine(DateTime.Now);
          });
        }
    }
}
