using System;
using System.Linq;

namespace LearnLINQ
{
    class SelectDemo
    { 
        static void Main()
        {
            double[] nums = {-10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5};
            var sqrRoot = from n in nums
                where n > 0
                select Math.Sqrt(n);
            Console.WriteLine("Square root positive number: ");
            foreach (var r in sqrRoot)
                Console.WriteLine("{0:#.##}", r);
        }
    }
}
