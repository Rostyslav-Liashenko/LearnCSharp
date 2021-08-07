using System;
using System.Threading;

namespace LearnThreading
{
    public class DecThread
    {
        public Thread Thrd { get; set; }

        public DecThread(string name)
        {
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Decrement(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
        }
    }
}
