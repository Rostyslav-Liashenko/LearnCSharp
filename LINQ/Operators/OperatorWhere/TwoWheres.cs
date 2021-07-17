using System;
using System.Linq;

namespace LearnLINQ
{
    class TwoWheres
    { 
        static void Main()
        {
            int[] nums = {1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 19};
            var PosNums = from n in nums
                where n > 0
                where n < 10
                select n;
            Console.WriteLine("Positive value and < 10");
            foreach (var i in PosNums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
