using System;
using System.Threading;

namespace LearnThreading
{
    public class SumArray
    {
        private int sum;
        public int SumIt(int[] nums)
        { 
            sum = 0;
            foreach (var el in nums)
            {
                sum += el;
                Console.WriteLine("Current summa for " + Thread.CurrentThread.Name + " equal " + sum);
            }
            Thread.Sleep(10);
            return sum;
        }
    }
}
