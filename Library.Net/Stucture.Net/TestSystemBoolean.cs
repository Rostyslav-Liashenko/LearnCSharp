using System;

namespace LearnLibrary
{
    class TestSystemBoolean
    {
        static void Main()
        {
            Boolean b = true;
            string str = b.ToString();
            Console.WriteLine(str);
            Console.WriteLine("Hash code = " + b.GetHashCode());
            bool anotherBool = Boolean.Parse("true");
            Console.WriteLine("Another bool = " + anotherBool);
        }
    }
}
