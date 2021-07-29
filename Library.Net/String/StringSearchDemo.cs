using System;

namespace LearnLibrary
{
    class StringSearchDemo
    {
        static void Main()
        {
            string str = "C# has efficient string processing facilities";
            int idx;
            Console.WriteLine("str: " + str);
            idx = str.IndexOf('o');
            Console.WriteLine("Index first symbol o: " + idx);
            idx = str.LastIndexOf('o');
            Console.WriteLine("Index last symbol o: " + idx);
            idx = str.IndexOf("sing", StringComparison.Ordinal);
            Console.WriteLine("Index first substring sing: " + idx);
            idx = str.LastIndexOf("sing", StringComparison.Ordinal);
            Console.WriteLine("Index last substring sing: " + idx);
            char[] chars = {'a', 'e', 'c'};
            idx = str.IndexOfAny(chars);
            Console.WriteLine("Index of first symbol a, e, c :" + idx);
            if (str.StartsWith("C# has efficient",StringComparison.Ordinal))
                Console.WriteLine("str begin with C# has efficient");
            if (str.EndsWith("facilities",StringComparison.Ordinal))
                Console.WriteLine("str end with facilities");
        }
    }
}
