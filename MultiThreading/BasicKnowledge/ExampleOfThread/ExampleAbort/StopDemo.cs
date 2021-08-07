using System;
using System.Threading;

namespace LearnThreading
{
    class StopDemo
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("My Thread");
            Thread.Sleep(1000);
            Console.WriteLine("Abort");
            mt1.Thrd.Abort(); // obsolete
            mt1.Thrd.Join();
            Console.WriteLine("Main thread is abort");
        }
    }
}
