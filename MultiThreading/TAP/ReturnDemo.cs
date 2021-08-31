using System;
using System.Threading.Tasks;

namespace LearnAsync
{
    static class AsyncAwaitDemo
    {

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static async Task<int> FactorialAsync(int n)
        {
            return await Task.Run(()=>Factorial(n));
        }
        
        static async Task Main(string[] args)
        {
            int n1 = await FactorialAsync(5);
            int n2 = await FactorialAsync(6);
            Console.WriteLine($"n1={n1}  n2={n2}");
            Console.Read();
        }
    }
}
