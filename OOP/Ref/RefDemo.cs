using System;

namespace ConsoleApp3
{
    class RefDemo
    {
        static void Main()
        {
            RefTest ob = new RefTest();
            int a = 10;
            Console.WriteLine("a = " + a);
            ob.Sqr(ref a);
            Console.WriteLine("a after method = " + a);
        }
    }
}
