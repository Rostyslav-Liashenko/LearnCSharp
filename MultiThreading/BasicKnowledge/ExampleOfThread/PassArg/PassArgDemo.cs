using System;
using System.Threading;

namespace LearnThreading
{
    class PassArgDemo
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("Child #1", 5);
            MyThread mt2 = new MyThread("Child #2", 3);
            do
            {
                Thread.Sleep(100);
            } while (mt1.Thrd.IsAlive || mt2.Thrd.IsAlive);
            Console.WriteLine("Main thread is end.");
        }
    }
}
