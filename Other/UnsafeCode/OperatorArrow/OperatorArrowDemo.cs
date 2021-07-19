using System;

namespace LearnPointer
{
    class OperatorArrowDemo
    {
        static unsafe void Main()
        {
            MyStructure o;
            MyStructure* p = &o;
            p->A = 9;
            p->B = 10;
            Console.WriteLine("{0} + {1} = {2}",p->A,p->B,p->Sum());
        }
    }
}
