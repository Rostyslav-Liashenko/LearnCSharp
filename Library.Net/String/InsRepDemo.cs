using System;

namespace LearnLibrary
{
    class InsRepDemo
    {
        static void Main()
        {
            string str = "It Is test";
            Console.WriteLine("Source string: " + str);
            str = str.Insert(6, "simple ");
            Console.WriteLine(str);
            str = str.Replace("simple", "not simple");
            Console.WriteLine(str);
            str = str.Replace('I', 'i');
            Console.WriteLine(str);
            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}
