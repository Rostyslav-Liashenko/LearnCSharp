using System;

namespace ConsoleApp4
{
    class objInitDemo
    {
        static void Main()
        {
            MyClass obj = new MyClass { count = 100, str = "Test" };
            Console.WriteLine(obj.count + " " + obj.str);
        }
    }
}
