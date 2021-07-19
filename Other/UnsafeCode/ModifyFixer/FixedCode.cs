using System;

namespace LearnPointer
{
    class FixedCode
    {
        static unsafe void Main()
        {
            Test o = new Test(19);
            fixed (int* p = &o.Num)
            {
                Console.WriteLine("Value: " + *p);
                *p = 10;
                Console.WriteLine("New value: " + *p);
            }
        }
    }
}
