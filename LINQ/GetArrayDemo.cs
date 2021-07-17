using System;
using System.Linq;

namespace LearnLINQ
{
    class GetArrayDemo
    {
        static void Main()
        {
            int[] nums = {1, -2, 3, -4, 5, -6, 7, 8};
            var positiveNums = from n in nums
                where n > 0
                select n;
            int[] processingArray = positiveNums.ToArray();
            foreach (var i in processingArray)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
