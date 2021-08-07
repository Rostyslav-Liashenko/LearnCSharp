using System;
using System.Threading;

namespace LearnThreading
{
    class UseMain
    {
        static void Main()
        {
            Thread Thrd = Thread.CurrentThread;
            if (Thrd.Name == null)
                Console.WriteLine("In main thread not have name");
            else
                Console.WriteLine("Main thread have name: " + Thrd.Name);
            Console.WriteLine("Priority: " + Thrd.Priority);
            Console.WriteLine();
            Console.WriteLine("Set name and priority");
            Thrd.Name = "Main thread";
            Thrd.Priority = ThreadPriority.AboveNormal;
            Console.WriteLine("Now. Main thread have name: '{0}' and her priority {1}", Thrd.Name, Thrd.Priority);
        }
    }
}
