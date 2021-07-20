using System;

namespace LearnPointer
{
    class NullableExperssionDemo
    {
        static void Main()
        {
            int? count = null;
            int? result = null;

            int incr = 10;
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Variable have value:" + result.Value);
            else 
                Console.WriteLine("Variable don't have value");
            count = 100;
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Variable have value:" + result.Value);
            else 
                Console.WriteLine("Variable don't have value");
        }
    }
}
