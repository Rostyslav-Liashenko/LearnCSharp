using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public Thread Thrd { get; set; }
        private ManualResetEvent mre;

        public MyThread(string name, ManualResetEvent evt)
        {
            Thrd = new Thread(Run);
            Thrd.Name = name;
            mre = evt;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine("In thread" + Thrd.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thrd.Name);
                Thread.Sleep(500);
            }
            Console.WriteLine(Thrd.Name + " end!");
            mre.Set();
        }
        
    }
}
