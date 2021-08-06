using System;
using System.Threading;

namespace LearnThreading
{
    public class IncThread
    {
        private int num;
        public Thread Thrd { get; set; }

        public IncThread(string name, int n)
        {
            Thrd = new Thread(Run);
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " waiting mutex");
            SharedRes.Mtx.WaitOne();
            Console.WriteLine(Thrd.Name + " get mutex");
            do
            {
                Thread.Sleep(500);
                SharedRes.Count++;
                Console.WriteLine("In thread " + Thrd.Name + ", SharedRes.Count = " + SharedRes.Count);
                num--;
            } while (num > 0);
            Console.WriteLine(Thrd.Name + " frees the mutex");
            SharedRes.Mtx.ReleaseMutex();
        }
    }
}
