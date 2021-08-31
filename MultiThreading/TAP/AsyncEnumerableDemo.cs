using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnAsync
{
    static class AsyncEnumerableDemo
    {
        private static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        
        static async Task Main()
        {
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }
    }
}
