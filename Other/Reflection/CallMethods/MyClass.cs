using System;

namespace LearnReflection
{
    public class MyClass
    {
        private int x;
        private int y;

        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            return (x < i && i < y);
        }

        public void Set(int a, int b)
        {
            Console.WriteLine("In method Set(int a, int b)");
            x = a;
            y = b;
            Show();
        }

        public void Set(double a, double b)
        {
            Console.WriteLine("In method Set(double a, double b)");
            x = (int) a;
            y = (int) b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Value x: {0}, value y: {1}", x, y);
        }
    }
}
