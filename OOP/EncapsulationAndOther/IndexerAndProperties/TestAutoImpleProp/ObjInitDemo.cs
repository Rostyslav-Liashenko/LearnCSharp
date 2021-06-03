using System;

namespace ConsoleApp4
{
    class ObjInitDemo
    {
        static void Main()
        {
            MyClass obj = new MyClass {Count = 100, Str = "Testing"};
            Console.WriteLine(obj.Count + " " + obj.Str);
        }
    }
}
