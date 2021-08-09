using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoTask
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
            Task tsk = new Task(MyTask);
            Task tsk2 = new Task(MyTask);
            tsk.Start();
            tsk2.Start();
            Console.WriteLine("ID task #1 = " + tsk.Id);
            Console.WriteLine("ID task #2 = " + tsk2.Id);
            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Main thread is finished");
        }
    }
}
