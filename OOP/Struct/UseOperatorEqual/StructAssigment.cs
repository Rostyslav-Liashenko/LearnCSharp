using System;

namespace LearnStructure
{
    class StructAssigment
    {
        static void Main()
        {
            MyStruct a;
            MyStruct b;
            a.X = 10;
            b.X = 20;
            Console.WriteLine("a.x {0}, b.x {1}",a.X,b.X);
            a = b;
            b.X = 30;
            Console.WriteLine("a.x {0}, b.x {1}",a.X,b.X);
        }
    }
}
