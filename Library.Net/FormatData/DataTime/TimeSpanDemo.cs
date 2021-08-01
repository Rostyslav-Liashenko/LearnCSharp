using System;

namespace LearnLibrary
{
    class TimeSpanDemo
    {
        static void Main()
        {
            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            DateTime end = DateTime.Now;
            TimeSpan span = end - start;
            Console.WriteLine("Time execution: {0:c}", span);
            Console.WriteLine("Time execution: {0:g}", span);
            Console.WriteLine("Time execution: {0:G}", span);
            Console.WriteLine("Time execution: 0.{0:fff} seconds", span);
        }
    }
}
