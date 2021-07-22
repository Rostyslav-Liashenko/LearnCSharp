using System;

namespace LearnLibrary
{
    class TestSystemInt32
    {
        static void Main()
        {
            Int32 someNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int32");
            Console.WriteLine("Max value: " + Int32.MaxValue);
            Console.WriteLine("Min value: " + Int32.MinValue);
            Console.WriteLine("Hash code:" + someNumber.GetHashCode());
            if (someNumber.Equals(5))
                Console.WriteLine("some number == 5 Equals");
            if (someNumber.CompareTo(5) == 0)
                Console.WriteLine("some number == 5 CompareTo");
            string str = someNumber.ToString();
            Console.WriteLine(str);
        }
    }
}
