using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoLambdaInvoke
    { 
        static void Main()
        { 
            Console.WriteLine("Main thread is begin.");
            Parallel.Invoke(
                () =>
                {
                    Console.WriteLine("Expression #1 is start");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("In expression #1 i = " + i);
                    }

                    Console.WriteLine("Expression #1 is end.");
                },
                () =>
                {
                    Console.WriteLine("Expression #2 is start");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("In expression #2 i = " + i);
                    }

                    Console.WriteLine("Expression #2 is end.");
                }
            );
            Console.WriteLine("Main thread is end.");
        }
    }
}
