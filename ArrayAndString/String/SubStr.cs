using System;

namespace ConsoleApp3
{
    class SubStr
    {
        static void Main()
        {
            string orgstr = "C# makes it easier to handle string.";
            string substr = orgstr.Substring(5, 20);
            Console.WriteLine("original string: " + orgstr);
            Console.WriteLine("substr: " + substr);
        }
    }
}
