using System;

namespace LearnPointer
{
    class NullableDemo
    {
        static unsafe void Main()
        {
            int? count = null;
            if (count.HasValue)
                Console.WriteLine("Variable have value:" + count.Value);
            else 
                Console.WriteLine("Variable not have value");
            count = 100;
            if (count.HasValue)
                Console.WriteLine("Variable have value:" + count.Value);
            else 
                Console.WriteLine("Variable not have value");
        }
    }
}
