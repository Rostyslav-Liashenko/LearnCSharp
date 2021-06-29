using System;

namespace LearnLambda
{
    delegate int NumOp(int a, int b);
    
    class UseLambda
    {
        static void Main()
        {
            NumOp add = (a, b) => a + b;
            NumOp sub = (a, b) => a - b;
            NumOp multiply = (a, b) => a * b;
            Console.WriteLine("5 + 2 = " + add(5,2));
            Console.WriteLine("5 - 2 = " + sub(5,2));
            Console.WriteLine("5 * 2 = " + multiply(5,2));
        }
    }
}
