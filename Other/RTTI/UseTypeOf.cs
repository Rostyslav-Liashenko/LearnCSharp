using System;
using System.IO;

namespace LearnRTTI
{
    class UseTypeOf
    {
        static void Main()
        {
            Type t = typeof(StreamReader);
            Console.WriteLine(t.FullName);
            if (t.IsClass) Console.WriteLine("Relative with class");
            Console.WriteLine(t.IsAbstract ? "Class is abstract" : "Class non-abstract");
        }
    }
}
