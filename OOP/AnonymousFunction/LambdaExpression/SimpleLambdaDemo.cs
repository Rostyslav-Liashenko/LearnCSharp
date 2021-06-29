using System;

namespace LearnLambda
{
    class SimpleLambdaDemo
    {
        delegate int Incr(int v);
        
        delegate bool IsEven(int v);
        
        static void Main()
        {
            Incr incr = count => count + 2;
            Console.WriteLine("Use lambda expression incr:");
            int x = -10;
            while (x <= 0)
            {
                Console.Write(x + " ");
                x = incr(x);
            }
            Console.WriteLine("\n");
            IsEven isEven = n => n % 2 == 0;
            Console.WriteLine("Use lambda expression isEven:");
            for (int i = 1; i <= 10; i++)
                if (isEven(i)) Console.WriteLine(i + " is even");
        }
    }
}
