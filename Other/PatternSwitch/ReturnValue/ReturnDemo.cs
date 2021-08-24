using System;

namespace LearnFeatures
{
    static class ReturnDemo
    {
        static int Select(char op, int a, int b) => op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            _ => throw new ArgumentException()
        };
        
        static  void Main()
        {
            Console.WriteLine(Select('+', 5, 2));
            Console.WriteLine(Select('-', 5, 2));
            Console.WriteLine(Select('*', 5, 2));
        }
    }
}
