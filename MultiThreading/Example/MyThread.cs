using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public int Count { get; private set; }
        private string thrdName;
        
        public MyThread(string name)
        {
            Count = 0;
            thrdName = name;
        }

        public void Run()
        {
            Console.WriteLine(thrdName + " begin.");
            do
            {
                Thread.Sleep(100);
                Console.WriteLine("In thread {0}, Count = {1}", thrdName, Count);
                Count++;
            } while (Count < 10);
            Console.WriteLine(thrdName + " is end.");
        }
    }
}
