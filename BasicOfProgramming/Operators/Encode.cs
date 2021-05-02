using System;

namespace ConsoleApp1
{
    class Encode
    {
        static void Main()
        {
            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 88;
            Console.WriteLine("Sources message: " + ch1 + ch2 + ch3);
            ch1 = (char) (ch1 ^ key);
            ch2 = (char) (ch2 ^ key);
            ch3 = (char) (ch3 ^ key);
            Console.WriteLine("Encrypt message: " + ch1 + ch2 + ch3);
            ch1 = (char) (ch1 ^ key);
            ch2 = (char) (ch2 ^ key);
            ch3 = (char) (ch3 ^ key);
            Console.WriteLine("Decrypt message: " + ch1 + ch2 + ch3);
        }
    }
}
