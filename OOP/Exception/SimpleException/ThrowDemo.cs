using System;

namespace LearnException
{
    class ThrowDemo
    { 
        static void Main()
        {
            try
            {
                Console.WriteLine("Before generation exception");
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception caught");
            }
            Console.WriteLine("Block after catch");
        }
    }
}
