using System;

namespace LearnInpAndOut
{
    class KbIn
    {
        static void Main()
        {
            Console.WriteLine("Press any key, after <Enter>");
            char ch = (char) Console.Read();
            Console.WriteLine("You pressed: " + ch);
        }
    }
}
