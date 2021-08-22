using System;

namespace LearnFeatures
{
    static class ProgramDemo
    {
        
        static string GetHello() => "Hello, World";

        static void SayHello() => Console.WriteLine("Hello, World");
        
        static void Main()
        {
            SayHello();
            Console.WriteLine(GetHello());
        }
    }
}
