using System;

namespace ConsoleApp5
{
    public class Sum // simple class for implementation sum of two number and trine overload operator
    {
        private double a;
        private double b;

        public Sum()
        {
            a = 0;
            b = 0;
        }

        public Sum(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine("a: " + a + " b:" + b);
        }
        
        public double GetSum()
        {
            return a + b;
        }
        
        public static Sum operator +(Sum a, Sum b)
        {
            Sum tmp = new Sum { a = a.a + b.a, b = a.b + b.b};
            return tmp;
        }

        public static Sum operator -(Sum a, Sum b)
        {
            Sum tmp = new Sum { a = a.a - b.a, b = a.b - b.b};
            return tmp;
        }

        public static Sum operator *(Sum a, Sum b)
        {
            Sum tmp = new Sum { a = a.a * b.a, b = a.b * b.b};
            return tmp;
        }

        public static Sum operator /(Sum a, Sum b)
        {
            Sum tmp = new Sum { a = a.a / b.a, b = a.b / b.b};
            return tmp;
        }

        public static bool operator >(Sum a, Sum b)
        {
            return a.GetSum() > b.GetSum();
        }

        public static bool operator <(Sum a, Sum b)
        {
            return a.GetSum() < b.GetSum();
        }
        
    }
}
