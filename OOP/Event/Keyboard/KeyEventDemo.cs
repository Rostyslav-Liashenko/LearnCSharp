using System;

namespace LearnEvent
{ 
    static class KeyEventDemo
    {
        static void Main()
        {
            Keyboard keyboard = new Keyboard();
            ConsoleKeyInfo key;
            int count = 0;
            keyboard.KeyPress += (sender, e) => 
                Console.WriteLine(" Receive message about key press:" + e.Ch);
            keyboard.KeyPress += (sender, e) =>
                count++;
            Console.WriteLine("Input some symbols and the end input point");
            do
            {
                key = Console.ReadKey();
                keyboard.OnKeyPress(key.KeyChar);
            } while (key.KeyChar != '.');
            Console.WriteLine($"Was pressed {count} times");
        }
    }
}
