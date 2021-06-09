using System;

namespace LearnInterfaceProperties
{
    class SeriesDemo3
    {
        static void Main()
        {
            ByTwos ob = new ByTwos();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number = " + ob.Next);
            Console.WriteLine("Begin from 21");
            ob.Next = 21;
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number = " + ob.Next);
            Console.WriteLine("Reset");
            ob.Next = 0;
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Next number " + ob[i]);
        }
    }
}
