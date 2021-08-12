using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoParallelFor
    {
        private static int[] data;

        static void MyTransform(int i)
        {
            data[i] = data[i] / 10;
            if (data[i] < 10000) data[i] = 0;
            if (data[i] > 10000 & data[i] < 20000) data[i] = 100;
            if (data[i] > 20000 & data[i] < 30000) data[i] = 200;
            if (data[i] > 30000) data[i] = 300;
        }
        static void Main()
        { 
            Console.WriteLine("Main thread is start");
            Stopwatch sw = new Stopwatch();
            data = new int[100000000];
            sw.Start();
            Parallel.For(0, data.Length, (i) => data[i] = i);
            sw.Stop();
            Console.WriteLine("Parallel init loop : {0} sec", sw.Elapsed.TotalSeconds);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < data.Length; i++)
                data[i] = i;
            sw.Stop();
            Console.WriteLine("Usually init loop: {0} sec",sw.Elapsed.TotalSeconds);
            Console.WriteLine();
            sw.Reset();
            sw.Start();
            Parallel.For(0, data.Length, MyTransform);
            sw.Stop();
            Console.WriteLine("Parallel execution loop : {0} sec",sw.Elapsed.TotalSeconds);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < data.Length; i++)
                MyTransform(i);
            sw.Stop();
            Console.WriteLine("Usually execution loop: {0} sec", sw.Elapsed.TotalSeconds);
            Console.WriteLine("Main thread is end.");
        }
    }
}
