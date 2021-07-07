using System;

namespace LearnPreprosseccor
{
    class InternalTest
    {
        internal int x;
    }
    
    class InternalDemo
    {
        static void Main()
        {
            InternalTest ob = new InternalTest();
            ob.x = 10;
            Console.WriteLine("Value ob.x " + ob.x);
        }
    }
}
