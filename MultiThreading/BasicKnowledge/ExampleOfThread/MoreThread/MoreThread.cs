using System;
using System.Threading;

namespace LearnThreading
{
    class MoreThread
    {
        static void Main()
        {
          Console.WriteLine("Main thread is begin.");
          MyThread mt = new MyThread("Child #1");
          MyThread mt2 = new MyThread("Child #2");
          MyThread mt3 = new MyThread("Child #3");
          do
          {
              Thread.Sleep(100);
              Console.Write(".");
          } while (mt.Count < 10 || mt2.Count < 10 || mt3.Count < 10);
          Console.WriteLine("Main thread is end.");
        }
    }
}
