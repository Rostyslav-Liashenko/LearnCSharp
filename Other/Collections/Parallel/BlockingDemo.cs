using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCollections
{
    static class BlockingDemo
    {
        private static BlockingCollection<char> bc;

        private static void Producer()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                bc.Add(ch);
                Console.WriteLine("Producing symbol: " + ch);
            }
        }

        static void Consumer()
        {
            Thread.Sleep(1000);
            for (int i = 0; i < 26; i++)
                Console.WriteLine("Consumer symbol: " + bc.Take());
        }
        
        static void Main()
        {
            bc = new BlockingCollection<char>(4);
            Task prod = new Task(Producer);
            Task con = new Task(Consumer);
            con.Start();
            prod.Start();
            try
            {
                Task.WaitAll(con, prod);
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                con.Dispose();
                prod.Dispose();
                bc.Dispose();
            }
        }
    }
}
