using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class ExampleOfSemaphore
    {
        private static Semaphore sem;

        static void MyPrintTaskId()
        {
            sem.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task id: {0} i = {1}", Task.CurrentId, i);
                Thread.Sleep(500);
            }
            sem.Release();
        }
        
        static void Main()
        {
            sem = new Semaphore(2, 2);
            Task tsk1 = Task.Factory.StartNew(MyPrintTaskId);
            Task tsk2 = Task.Factory.StartNew(MyPrintTaskId);
            Task tsk3 = Task.Factory.StartNew(MyPrintTaskId);
            Task tsk4 = Task.Factory.StartNew(MyPrintTaskId);
            Task tsk5 = Task.Factory.StartNew(MyPrintTaskId);
            Task.WaitAll(tsk1, tsk2, tsk3, tsk4, tsk5);
        }
    }
}
