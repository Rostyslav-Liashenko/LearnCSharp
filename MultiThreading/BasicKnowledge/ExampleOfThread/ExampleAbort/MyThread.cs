using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public Thread Thrd { get; set; }

        public MyThread(string name)
        {
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        private void Run()
        {
            Console.WriteLine(Thrd.Name + " begin...");
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(250);
                }
            }
        }
    }
}
