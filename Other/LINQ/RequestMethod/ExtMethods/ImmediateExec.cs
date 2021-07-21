using System;
using System.Linq;

namespace LearnLINQ
{
    class ImmediateExec
    {
        static void Main()
        {
            int[] nums = {1, -2, 3, 0, -4, 5};
            int len = (from n in nums
                where n > 0
                select n).Count();
            Console.WriteLine("Count positive number: " + len);
        }
    }
}
