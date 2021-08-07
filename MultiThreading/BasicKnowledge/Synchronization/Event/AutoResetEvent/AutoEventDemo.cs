using System;
using System.Threading;

namespace LearnThreading
{
    class AutoEventDemo
    {
        static void Main()
        {
            AutoResetEvent evtObj = new AutoResetEvent(false);
            MyThread mt1 = new MyThread("Event thread #1", evtObj);
            Console.WriteLine("Main thread waiting event");
            evtObj.WaitOne();
            Console.WriteLine("Main thread receive message about event from first thread");
            mt1 = new MyThread("Event thread #2", evtObj);
            evtObj.WaitOne();
            Console.WriteLine("Main thread receiver event from second thread");
            
        }
    }
}
