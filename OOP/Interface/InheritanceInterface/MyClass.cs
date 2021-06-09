using System;

namespace LearnInterfaceProperties
{
    public class MyClass : IB
    {
        public void Meth1()
        {
            Console.WriteLine("Implementation meth1");
        }

        public void Meth2()
        {
            Console.WriteLine("Implementation meth2");
        }

        public void Meth3()
        {
            Console.WriteLine("Implementation meth3");
        }
    }
}
