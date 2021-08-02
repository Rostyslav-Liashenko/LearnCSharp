using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public int Count { get; set; }
        private Thread Thrd;

        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        private void Run()
        {
            Console.WriteLine(Thrd.Name + " is begin.");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In thread " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine(Thrd.Name + " is end.");
        }
            
    }
}
