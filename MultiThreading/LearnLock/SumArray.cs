using System;
using System.Threading;

namespace LearnThreading
{
    public class SumArray
    {
        private int sum;
        private readonly object lockOn = new object();

        public int SumIt(int[] nums)
        {
            lock (lockOn)
            {
                sum = 0;
                foreach (var el in nums)
                {
                    sum += el;
                    Console.WriteLine("Current summa for " + Thread.CurrentThread.Name + " equal " + sum);
                }
                Thread.Sleep(10);
            }
            return sum;
        }
    }
}
