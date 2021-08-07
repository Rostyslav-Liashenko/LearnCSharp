using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        private static bool stop;
        private static string currentName;
        
        public int Count { get; set; }
        public Thread Thrd { get; set; }

        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(Run);
            Thrd.Name = name;
            currentName = name;
        }

        private void Run(object num)
        {
            Console.WriteLine(Thrd.Name + " is begin with count " + num);
            do
            {
                Count++;
                if (currentName != Thrd.Name)
                {
                    currentName = Thrd.Name;
                    Console.WriteLine("In thread " + currentName);
                }
            } while (!stop && Count < 100000000);

            stop = true;
            Console.WriteLine(Thrd.Name + " is end.");
        }
            
    }
}
