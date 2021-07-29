using System;
using System.Globalization;

namespace LearnLibrary
{
    class UpperLowerDemo
    {
        static void Main()
        {
            Console.WriteLine("input the some string: ");
            string input = Console.ReadLine();
            Console.WriteLine("To upper: " + input.ToUpper(CultureInfo.CurrentCulture));
            Console.WriteLine("To lower: " + input.ToLower(CultureInfo.CurrentCulture));
        }
    }
}
