using System;

namespace LearnLambda
{
    delegate int IntOp(int end);
    
    class StatementLambdaDemo
    {
        static void Main()
        {
            IntOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                    r *= i;
                return r;
            };
            Console.WriteLine("Factorial 3 = " + fact(3));
            Console.WriteLine("factorial 5 = " + fact(5));
        }
    }
}
