using System;
using System.Threading;

namespace LearnThreading
{
    class PriorityDemo
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("Highest priority");
            MyThread mt2 = new MyThread("Lower priority");
            mt1.Thrd.Priority = ThreadPriority.Highest;
            mt2.Thrd.Priority = ThreadPriority.BelowNormal;
            mt1.Thrd.Start();
            mt2.Thrd.Start();
            mt1.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine();
            Console.WriteLine("Thread " + mt1.Thrd.Name + " Count = " + mt1.Count);
            Console.WriteLine("Thread " + mt2.Thrd.Name + " Count = " + mt2.Count);
            Console.WriteLine("Main thread is end.");
        }
    }
}
