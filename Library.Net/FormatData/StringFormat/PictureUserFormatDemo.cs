using System;

namespace LearnLibrary
{
    class PictureUserFormatDemo
    {
        static void Main()
        {
            double num = 64354.2345;
            Console.WriteLine("Default format: " + num);
            Console.WriteLine("Value from 2: {0:#.##}", num);
            Console.WriteLine("Added ,: {0:#,###.##}", num);
            Console.WriteLine("EXP {0:#.###e+00}", num);
            Console.WriteLine("Depict different value positive and negative and zero.");
            Console.WriteLine("{0:#.#;(#.##);0.00}", num);
            num = -num;
            Console.WriteLine("{0:#.#;(#.##);0.00}", num);
            num = 0.0;
            Console.WriteLine("{0:#.#;(#.##);0.00}", num);
            num = 0.17;
            Console.WriteLine("Percent: {0:#%}", num);
        }
    }
}
