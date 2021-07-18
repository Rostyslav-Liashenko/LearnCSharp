using System;
using System.Linq.Expressions;

namespace LearnLINQ
{
    class SimpleExpTree
    {
        static void Main()
        {
            Expression<Func<int, int, bool>>
                IsFactorExp = (n, d) => (d != 0) ? (n % d) == 0 : false;
            Func<int, int, bool> IsFactor = IsFactorExp.Compile();
            if (IsFactor(10,5))
                Console.WriteLine("10 / 5");
            if (!IsFactor(7,10))
                Console.WriteLine("7 not / 10");
            
        }
    }
}
