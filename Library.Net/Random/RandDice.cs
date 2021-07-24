using System;

namespace LearnLibrary
{
    class RandDice
    {
        static void Main()
        {
            Random ran = new Random();
            Console.Write(ran.Next(1,7) + " " + ran.Next(1,7));
        }
    }
}
