using System;

namespace LearnGeneralization
{
    public class CompareDemo
    {
        public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
        {
            foreach (T v in obs)
                if (v.Equals(what))
                    return true;
            return false;
        }

        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if (what.CompareTo(obs[0]) < 0 || what.CompareTo(obs[obs.Length - 1]) > 0)
                return false;
            return true;
        }

        public static void Main()
        {
            int[] nums = {1, 2, 3, 4, 5};
            if (IsIn(2, nums))
                Console.WriteLine("Find value 2");
            if (IsIn(99,nums))
                Console.WriteLine("Not output!!!");
            MyClass[] mcs = { new MyClass(1), new MyClass(2), new MyClass(3), new MyClass(4)};
            if (IsIn(new MyClass(1),mcs))
                Console.WriteLine("Funded object MyClass()");
            if (IsIn(new MyClass(99),mcs))
                Console.WriteLine("Not output!!!");
            if (InRange(2, nums))
                Console.WriteLine("Value 2 in range array nums");
            if (InRange(new MyClass(2),mcs))
                Console.WriteLine("Object MyClass(2) in range array nums");

        }
    }
}
