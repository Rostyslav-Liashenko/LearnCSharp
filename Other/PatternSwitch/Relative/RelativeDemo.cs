using System;

namespace LearnFeatures
{
    static class RelativeDemo
    {
        static decimal Calculate(decimal sum) => sum switch
        {
            <= 0 => 0,
            < 50000 => sum * 0.05m,
            < 100000 => sum * 0.1m,
            _ => sum * 0.2m
        };
        
        static  void Main()
        {
            Console.WriteLine(Calculate(-200));     // 0
            Console.WriteLine(Calculate(0));        // 0 
            Console.WriteLine(Calculate(10000));    // 500
            Console.WriteLine(Calculate(60000));    // 6000
            Console.WriteLine(Calculate(200000));   // 40000
        }
    }
}
