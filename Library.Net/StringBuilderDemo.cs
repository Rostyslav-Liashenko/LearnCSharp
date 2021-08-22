using System;
using System.Text;

namespace LearnFeatures
{
    static class StringBuilderDemo
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Title: ");
            Console.WriteLine($"Length string: {sb.Length}");
            Console.WriteLine($"Capacity string: {sb.Capacity}");
            sb.Append(" book");
            Console.WriteLine($"Length string: {sb.Length}");
            Console.WriteLine($"Capacity string: {sb.Capacity}");
            sb.Append(" of C#");
            Console.WriteLine($"Length string: {sb.Length}");
            Console.WriteLine($"Capacity string: {sb.Capacity}");
            StringBuilder sb2 = new StringBuilder("Hello World");
            sb2.Append("!");
            sb2.Insert(0, "... ");
            Console.WriteLine(sb2);
            sb2.Remove(0, 9);
            Console.WriteLine(sb2);
            Console.WriteLine(sb2.ToString());
        }
    }
}
