using System;

namespace LearnStructure
{
    class EnumDemo
    {
        enum Apple
        {
            Jonathan,
            GoldenDel,
            RedDel,
            Winesap,
            Cortland,
            McIntosh
        };
        static void Main()
        {
            string[] color =
            {
                "red",
                "yellow",
                "red",
                "red",
                "red",
                "red-green"
            };
            for (Apple i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine(i + " have value " + (int) i);
            Console.WriteLine();
            for (Apple i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine("Color " + i + " - " + color[(int) i]);
        }
    }
}
