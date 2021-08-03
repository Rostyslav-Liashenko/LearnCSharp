using System;
using System.Threading;

namespace LearnThreading
{
    public class MyThread
    {
        public Thread Thrd { get;}
        private int[] a;
        private int answer;
        private static SumArray sa = new SumArray();

        public MyThread(string name, int[] nums)
        {
            a = nums;
            Thrd = new Thread(Run) {Name = name};
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " is begin");
            answer = sa.SumIt(a);
            Console.WriteLine("Summa for thread " + Thrd.Name +
                              " equal " + answer);
            Console.WriteLine(Thrd.Name + " is end.");
        }
    }
}
