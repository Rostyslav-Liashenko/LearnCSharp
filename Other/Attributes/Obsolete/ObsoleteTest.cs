using System;

namespace LearAttribute
{
    class TestObsolete
    {
        [Obsolete("You need use MyMeth2")]
        public static int MyMeth(int a, int b)
        {
            return a / b;
        }

        public static int MyMeth2(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }

        static void Main()
        {
            Console.WriteLine("4 / 3 = " + MyMeth(4,3));
            Console.WriteLine("4 / 3 = " + MyMeth2(4,3));
        }
    }
}
