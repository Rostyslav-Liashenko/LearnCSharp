using System;

namespace LearnInpAndOut
{
    class ReadChars2
    {
        static void Main()
        {
            Console.WriteLine("Press any key, after <Enter>");
            string str = Console.In.ReadLine();
            Console.WriteLine("You pressed: " + str);
        }
    }
}
