using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoLambdaTask
    {
        static void Main()
        { 
            Console.WriteLine("Main thread is start");
            Task tsk = Task.Factory.StartNew(
                () =>
                {
                  Console.WriteLine("Task is start");
                  for (int i = 0; i < 10; i++)
                  {
                      Thread.Sleep(500);
                      Console.WriteLine("Count = " + i);
                  }
                  Console.WriteLine("Task is end");
                });
            tsk.Wait();
            tsk.Dispose();
            Console.WriteLine("Main thread is finished");
        }
    }
}
