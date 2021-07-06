using System;

namespace NS1
{
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Constructor class ClassA");
        }
    }
    
    namespace NS2
    {
        class ClassB
        {
            public ClassB()
            {
                Console.WriteLine("Constructor classB");
            }
        }
    }
}

class NestedNSDemo
{
    static void Main()
    {
        NS1.ClassA a = new NS1.ClassA();
        NS1.NS2.ClassB b = new NS1.NS2.ClassB();
    }
}
