using System;
using System.Threading;

namespace LearnThreading
{
    public class IncThread
    {
        public Thread Thrd { get; set; }

        public IncThread(string name)
        {
            Thrd = new Thread(Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
            
        }
    }
}
