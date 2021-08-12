using System;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoParallelForBreak
    {
        private static int[] data;
        
        static void MyTransform(int i, ParallelLoopState pls)
        {
            if (data[i] < 0) pls.Break();
            
            data[i] = data[i] / 10;
            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 & data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 & data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }
        static void Main()
        { 
            Console.WriteLine("Main thread is start.");
            data = new int[1000000000];
            for (int i = 0; i < data.Length; i++)
                data[i] = i;
            data[1000] = -10;
            ParallelLoopResult loopResult = Parallel.For(0, data.Length, MyTransform);
            if (!loopResult.IsCompleted)
                Console.WriteLine("Loop is break. Index = " + loopResult.LowestBreakIteration);
            Console.WriteLine("Main thread is end.");
        }
    }
}
