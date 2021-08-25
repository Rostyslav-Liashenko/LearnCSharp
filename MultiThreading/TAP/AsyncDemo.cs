using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace LearnAsync
{
    class AsyncDemo
    {

        static async void ReadWriteAsync()
        {
            string s = "Hello world! One step at a time";
            using (StreamWriter writer = new StreamWriter("hello.txt",false))
            {
                await writer.WriteLineAsync(s);
            }

            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();
                Console.WriteLine(result);
            }
        }
        
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(5000);
            return result;
        }
        
        
        static async void FactorialAsync(int n)
        {
            int x = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Factorial {n} = {x}");
        }
        
        static void Main()
        {
            FactorialAsync(6);
            ReadWriteAsync();
            Console.WriteLine("Some Work");
            Console.ReadLine();
        }
    }
}
