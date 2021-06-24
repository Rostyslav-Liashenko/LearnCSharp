using System;

namespace LearnInpAndOut
{
    class ErrOut
    {
        static void Main()
        {
            int a = 10, b = 0;
            try
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            catch (DivideByZeroException)
            {
                Console.Error.WriteLine("You cannot divided by zero");
            }
        }
    }
}
