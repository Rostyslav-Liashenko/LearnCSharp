using System;
using System.Linq;

namespace LearnLINQ
{
    class GroupDemo
    {
        static void Main()
        {
            string[] strs = {"alpha", "beta", "gamma"};
            var chrs = from str in strs
                let chrArray = str.ToCharArray()
                from ch in chrArray
                orderby ch
                select ch;
            Console.WriteLine("Several symbol");
            foreach (var c in chrs)
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
