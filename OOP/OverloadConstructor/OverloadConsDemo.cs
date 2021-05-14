using System;

namespace ConsoleApp4
{
    class OverloadConsDemo
    {
        static void Main()
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass(88);
            MyClass t3 = new MyClass(17.23);
            MyClass t4 = new MyClass(2, 4);
            
            Console.WriteLine("t1.x:" + t1.GetX());
            Console.WriteLine("t2.x:" + t2.GetX());
            Console.WriteLine("t3.x:" + t3.GetX());
            Console.WriteLine("t4.x:" + t4.GetX());
        }
    }
}
