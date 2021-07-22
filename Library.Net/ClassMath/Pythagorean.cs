using System;

namespace LearnLibrary
{
    class Pythagorean 
    {
        static void Main()
        {
            Console.WriteLine("Input the length first said triangle: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the length second said triangle: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            double hypot = Math.Sqrt(Math.Pow(s1,2) + Math.Pow(s2,2));
            Console.WriteLine("Hypot length = " + hypot);
        }
    }
}
