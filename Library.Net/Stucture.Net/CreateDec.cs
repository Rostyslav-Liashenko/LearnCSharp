using System;

namespace LearnLibrary
{
    class CreateDec
    {
        static void Main()
        {
            decimal d = new decimal(12345, 0, 0, false, 2);
            Console.WriteLine(d);
        }
    }
}
