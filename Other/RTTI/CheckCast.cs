using System;

namespace LearnRTTI
{
    class A { }

    class B : A
    { }
    
    class CheckCast
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            b = a as B;
            Console.WriteLine(b == null ? " b == null" : "b != null");
        }
    }
}
