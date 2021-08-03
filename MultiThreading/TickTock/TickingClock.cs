using System;

namespace LearnThreading
{
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
