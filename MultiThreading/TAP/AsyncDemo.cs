using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnAsync
{
    class AsyncDemo
    {
        
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
                result *= i;
            Thread.Sleep(8000);
            Console.WriteLine($"Factorial = {result}");
        }

        static async void FactorialAsync()
        {
            Console.WriteLine("Begin method FactorialAsync");
            await Task.Run(() => Factorial());
            Console.WriteLine("End of method FactorialAsync");
        }
        
        static void Main()
        {
            FactorialAsync();
            Console.WriteLine("Input the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Square number {n} = {n * n}");
            Console.WriteLine("End of method Main");
            Console.ReadLine();
        }
    }
}
