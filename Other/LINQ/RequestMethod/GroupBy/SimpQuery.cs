using System;
using System.Linq;

namespace LearnLINQ
{
    class SimpQuery
    {
        static void Main()
        {
            int[] nums = {1, -2, 3, 0, -4, 5};
            var posNums = nums.Where(n => n > 0).Select(r => r);
            Console.WriteLine("Positive number");
            foreach (var i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
