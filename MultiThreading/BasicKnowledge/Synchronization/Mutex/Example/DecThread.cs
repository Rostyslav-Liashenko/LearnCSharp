using System;
using System.Threading;

namespace LearnThreading
{
    public class DecThread
    {
        private int num;
        public Thread Thrd { get; set; }

        public DecThread(string name, int n)
        {
            Thrd = new Thread(new ThreadStart(Run));
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " waiting mutex");
            SharedRes.Mtx.WaitOne();
            Console.WriteLine(Thrd.Name + " receive mutex");
            do
            {
                Thread.Sleep(500);
                SharedRes.Count--;
                Console.WriteLine("In thread " + Thrd.Name + ", SharedRes.Count = " + SharedRes.Count);
                num--;
            } while (num > 0);
            SharedRes.Mtx.ReleaseMutex();
            Console.WriteLine(Thrd.Name + " mutex released");
        }
    }
}
