using System;

namespace LearnInpAndOut
{
    class ReadKeys
    {
        static void Main()
        {
            ConsoleKeyInfo keypress;
            Console.WriteLine("Input the some symbols, for the exit <Q>");
            do
            {
                keypress = Console.ReadKey();
                Console.WriteLine(" You pressed key:" + keypress.KeyChar);
                if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
                    Console.WriteLine("Pressed key <ALT>");
                if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
                    Console.WriteLine("Press key <CTRL>");
                if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
                    Console.WriteLine("Press key <Shift>");
            } while (keypress.KeyChar != 'Q');
        }
    }
}
