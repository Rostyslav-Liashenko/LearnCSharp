using System;

namespace LearnThreading
{
    class JoinThread
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("Child #1");
            MyThread mt2 = new MyThread("Child #2");
            MyThread mt3 = new MyThread("Child #3");
            mt1.Thrd.Join();
            Console.WriteLine("Child #1 is join");
            mt2.Thrd.Join();
            Console.WriteLine("Child #2 is join");
            mt3.Thrd.Join();
            Console.WriteLine("Child #3 is join");
        }
    }
}
