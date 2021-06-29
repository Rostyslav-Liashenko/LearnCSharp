using System;

namespace LearnAnonymoss
{
    delegate int CountIt(int end);
    
    class AnonMethDemo3
    {
        static void Main()
        {
            CountIt count = delegate(int fin)
            {
                int sum = 0;
                for (int i = 0; i <= fin; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                return sum;
            };
            int result = count(3);
            Console.WriteLine("Result: " + result);
            result = count(5);
            Console.WriteLine("Result: " + result);
        }
    }
}
