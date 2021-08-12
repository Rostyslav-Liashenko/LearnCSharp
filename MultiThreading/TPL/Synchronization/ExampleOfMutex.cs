using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoParallelForEach
    {
        private static Mutex mtx;

        static void MyPrintTaskId()
        {
            mtx.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task id: {0}", Task.CurrentId);
                Thread.Sleep(500);
            }
            mtx.ReleaseMutex();
        }
        
        static void Main()
        {
            mtx = new Mutex();
            Task tsk1 = Task.Factory.StartNew(MyPrintTaskId);
            Task tsk2 = Task.Factory.StartNew(MyPrintTaskId);
            Task.WaitAll(tsk1, tsk2);
            tsk1.Dispose();
            tsk2.Dispose();
        }
    }
}
