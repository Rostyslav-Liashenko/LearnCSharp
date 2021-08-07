using System;
using System.Threading;

namespace LearnThreading
{
    class MultiThread
    {
        static void Main()
        {
           Console.WriteLine("Main thread begin.");
           MyThread mt = new MyThread("child #1");
           Thread newThrd = new Thread(mt.Run);
           newThrd.Start();
           do
           {
               Console.Write(".");
               Thread.Sleep(100);
           } while (mt.Count != 10);
           Console.WriteLine("Main thread is end.");
        }
    }
}
