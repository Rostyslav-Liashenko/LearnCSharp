using System;
using System.Linq;

namespace LearnLINQ
{
    class LetDemo
    {
        static void Main()
        {
            int[] nums = {1, 2, 3, 5, 6,};
            var query = from el in nums
                let someAdd = el + 5
                select someAdd;
            foreach (var el in query)
                Console.Write(el + " ");
            Console.WriteLine();
        }
    }
}
