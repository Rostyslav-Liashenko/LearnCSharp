using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoTaskFactory
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() #" + Task.CurrentId + " is start");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyTask() #" + Task.CurrentId + ", count = " + i);
            }
            Console.WriteLine("MyTask #" + Task.CurrentId + " is end");
        }
        
        static void Main()
        {
            Task tsk = Task.Factory.StartNew(MyTask);
            Task tsk2 = Task.Factory.StartNew(MyTask);
            Console.WriteLine("ID task #1 = " + tsk.Id);
            Console.WriteLine("ID task #2 = " + tsk2.Id);
            Task.WaitAll(tsk, tsk2);
            Console.WriteLine("Main thread is finished");
        }
    }
}
