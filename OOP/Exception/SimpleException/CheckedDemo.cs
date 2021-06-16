using System;

namespace LearnException
{
    class CheckedDemo
    {
        public static void Main()
        {
            byte a = 127, b = 127, result = 0;
            try
            {
                result = unchecked((byte) (a * b));
                Console.WriteLine("Result unchecked for overflow:" + result);
                result = checked((byte) (a * b));
            }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception);
            }
            Console.WriteLine("result = {0}", result);
        }
    }
}
