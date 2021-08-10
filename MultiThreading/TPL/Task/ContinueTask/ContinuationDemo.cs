using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class ContinuationDemo
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() is start");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyTask() count = " + i);
            }
            Console.WriteLine("My task is end.");
        }

        static void ContTask(Task t)
        {
            Console.WriteLine("Continue task is start");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In continue count = " + i);
            }
            Console.WriteLine("Continue is end.");
        }

        static void Main()
        {
            Console.WriteLine("Main thread is start");
            Task tsk = new Task(MyTask);
            Task taskCont = tsk.ContinueWith(ContTask);
            tsk.Start();
            taskCont.Wait();
            tsk.Dispose();
            taskCont.Dispose();
            Console.WriteLine("Main thread is finished");
        }
    }
}
