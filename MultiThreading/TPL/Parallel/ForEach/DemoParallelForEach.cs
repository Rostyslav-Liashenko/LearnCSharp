using System;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoParallelForEach
    {
        private static int[] data;
        
        static void DisplayData(int v, ParallelLoopState pls)
        {
            if (v < 0) pls.Break();
            Console.WriteLine("Value: " + v);
        }
        static void Main()
        { 
            Console.WriteLine("Main thread is start.");
            data = new int[1000000000];
            for (int i = 0; i < data.Length; i++)
                data[i] = i;
            data[100000] = -10;
            ParallelLoopResult loopResult = Parallel.For(0, data.Length, DisplayData);
            if (!loopResult.IsCompleted)
                Console.WriteLine("Loop is break. Index = " + loopResult.LowestBreakIteration);
            Console.WriteLine("Main thread is end.");
        }
    }
}
