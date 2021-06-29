using System;

namespace LearnAnonymoss
{
    delegate int CountIt(int end);
    
    class VarCapture
    {
        static CountIt Counter()
        {
            int sum = 0;
            CountIt ctObj = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i + "");
                    sum += i;
                }
                return sum;
            };
            return ctObj;
        }
        
        
        static void Main()
        {
            CountIt count = Counter();
            int result = count(3);
            Console.WriteLine("Summa 3 = " + result);
            Console.WriteLine();
            result = count(5);
            Console.WriteLine("Summa 5 = " + result);
        }
    }
}
