using System;
using System.Collections.Concurrent;
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
            bc.CompleteAdding();
        }

        static void Consumer()
        {
            while (!bc.IsCompleted)
            {
                if (bc.TryTake(out char ch))
                    Console.WriteLine("Consume: " + ch);
            }
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
