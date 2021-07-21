using System;
using System.Linq;

namespace LearnLINQ
{
    class OrderbyDemo
    { 
        static void Main()
        {
            int[] nums = {10, -19, 4, 7, 2, -5, 0};
            var posNums = from n in nums
                orderby n descending 
                select n;
            Console.WriteLine("Value of ascending");
            foreach (var i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
