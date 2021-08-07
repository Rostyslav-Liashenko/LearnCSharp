using System;
using System.Threading;

namespace LearnThreading
{
    class ManualEventDemo
    {
        static void Main()
        {
            ManualResetEvent evtObj = new ManualResetEvent(false);
            MyThread mt1 = new MyThread("Event thread #1", evtObj);
            Console.WriteLine("Main thread waiting event");
            evtObj.WaitOne();
            Console.WriteLine("Main thread receive message about event from first thread");
            evtObj.Reset();
            mt1 = new MyThread("Event thread #2", evtObj);
            evtObj.WaitOne();
            Console.WriteLine("Main thread receiver event from second thread");
            
        }
    }
}
