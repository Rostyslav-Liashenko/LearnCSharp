using System;
using System.Linq;

namespace LearnLINQ
{
    class MultipleForms
    {
        static void Main()
        {
            char[] chrs = {'A', 'B', 'C'};
            char[] chrs2 = {'X', 'Y', 'Z'};
            var pairs = from ch1 in chrs
                from ch2 in chrs2
                select new ChPair(ch1, ch2);
            Console.WriteLine();
            foreach (var p in pairs)
                Console.WriteLine("{0} {1}", p.First, p.Second);
        }
    }
}
