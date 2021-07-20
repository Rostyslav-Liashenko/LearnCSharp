using System;

namespace LearnPointer
{
    class FixedString
    {
        static unsafe void Main()
        {
            string str = "It is test";
            fixed (char* p = str)
            {
                for (int i = 0; p[i] != 0; i++)
                    Console.Write(p[i]);
            }
            Console.WriteLine();
        }
    }
}
