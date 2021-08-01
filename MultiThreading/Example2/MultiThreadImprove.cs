using System;
using System.Threading;

namespace LearnThreading
{
    class MultiThreadImprove
    {
        static void Main()
        {
          Console.WriteLine("Main thread is begin.");
          MyThread mt = new MyThread("Child #1");
          do
          {
              Thread.Sleep(100);
              Console.Write(".");
          } while (mt.Count != 10);
          Console.WriteLine("Main thread is end.");
        }
    }
}
