using System;

namespace LearnInterfaceProperties
{
    public class FQIFNames
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            Console.WriteLine("Call method IMyIF_A.Meth(): " + ob.MethA(3));
            Console.WriteLine("Call method IMyIF_B.Meth(): " + ob.MethB(3));
        }
    }
}
