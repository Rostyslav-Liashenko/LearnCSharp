using System;

namespace LearnRTTI
{
    class A { }

    class B : A
    { }
    
    class UseIs
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            if (a is A)
                Console.WriteLine("a have type Class A");
            if (b is A)
                Console.WriteLine("b have type class A, because B inheritance A");
            if (a is B)
                Console.WriteLine("No output");
            if (b is B)
                Console.WriteLine("b have type class B");
            if (a is object)
                Console.WriteLine("a have type object");
        }
    }
