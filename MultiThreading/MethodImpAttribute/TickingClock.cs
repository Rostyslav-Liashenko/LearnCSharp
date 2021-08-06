using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LearnThreading
{
    public class TickTock
    {
        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public void Tick(bool running)
        { 
            if (!running) 
            { 
                Monitor.PulseAll(this);
                return;
            }
            Console.Write("tik ");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }

        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public void Tock(bool running)
        {
            if (!running)
            {
                Monitor.PulseAll(this);
                return;
            }
            
            Console.WriteLine("tak ");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }
    }
    
    public class MyThread
    {
        public Thread Thrd { get; set; }
        private TickTock ttOb;

        public MyThread(string name, TickTock tt)
        {
            Thrd = new Thread(Run);
            ttOb = tt;
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tick(true);
                ttOb.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ttOb.Tock(true);
                ttOb.Tock(false);
            }
            
        }
    }
    
    class TickingClock
    {
        static void Main()
        {
            TickTock tt = new TickTock();
            MyThread mt1 = new MyThread("Tick", tt);
            MyThread mt2 = new MyThread("Tock", tt);
            mt1.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine("Clock is stop");
        }
    }
}
