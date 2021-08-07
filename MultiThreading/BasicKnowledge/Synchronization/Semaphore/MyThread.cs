using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public Thread Thrd { get; set; }
        static Semaphore sem = new Semaphore(2, 2);

        public MyThread(string name)
        {
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        private void Run()
        {
            Console.WriteLine(Thrd.Name + " pending permission");
            sem.WaitOne();
            Console.WriteLine(Thrd.Name + " receive permission");
            for (char ch = 'A'; ch < 'D'; ch++)
            {
                Console.WriteLine(Thrd.Name + " : " + ch + " ");
                Thread.Sleep(500);
            }
            Console.WriteLine(Thrd.Name + " frees up resources");
            sem.Release();
        }
    }
}
