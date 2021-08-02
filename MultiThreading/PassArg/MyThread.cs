using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public int Count { get; set; }
        public Thread Thrd { get; set; }

        public MyThread(string name, int num)
        {
            Count = 0;
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start(num);
        }

        private void Run(object num)
        {
            Console.WriteLine(Thrd.Name + " is begin with count " + num);
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In thread " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < (int) num);
            Console.WriteLine(Thrd.Name + " is end.");
        }
            
    }
}
