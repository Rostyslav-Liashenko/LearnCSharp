using System;

namespace ConsoleApp4
{
    public class MyClass
    {
        private int _x;
        
        public MyClass()
        {
            Console.WriteLine("In const MyClass()");
            _x = 0;
        }

        public MyClass(int i)
        {
            Console.WriteLine("In const MyClass(int)");
            _x = i;
        }

        public MyClass(double d)
        {
            Console.WriteLine("In const MyClass(double)");
            _x = (int) d;
        }

        public MyClass(int i, int j)
        {
            Console.WriteLine("In const MyClass(int, int)");
            _x = i * j;
        }

        public int GetX()
        {
            return _x;
        }
        
    }
}
