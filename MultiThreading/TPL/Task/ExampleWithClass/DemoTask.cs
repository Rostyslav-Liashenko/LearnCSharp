using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnTPL
{
    class DemoTask
    {
        static void Main()
        {
            Console.WriteLine("Main thread is start");
            MyClass mc = new MyClass();
            Task tsk = new Task(mc.MyTask);
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
