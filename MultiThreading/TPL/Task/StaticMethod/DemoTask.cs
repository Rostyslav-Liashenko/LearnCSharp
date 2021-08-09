using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoTask
    {

        static void MyTask()
        {
            Console.WriteLine("MyTask() is start");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In method MyTask(), count = " + i);
            }

            Console.WriteLine("MyTask() is end");
        }
        
        static void Main()
        {
            Console.WriteLine("Main thread is start");
            Task tsk = new Task(MyTask);
            tsk.Start();
            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Main thread is end");
        }
    }
}
