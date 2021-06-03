using System;

namespace ConsoleApp3
{
    class AccessDemo
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            ob.SetAlpha(-99);
            ob.SetBetta(19);
            Console.WriteLine("ob.alpha = " + ob.GetAlpha());
            Console.WriteLine("ob.betta = " + ob.GetBetta());
        }
    }
}
