using System;

namespace ConsoleApp3
{
    class StringSwitch
    {
        static void Main()
        {
            string[] strs = {"one", "two", "three", "two", "one"};
            foreach (string s in strs)
            {
                switch (s)
                {
                    case "one":
                        Console.Write(1);
                        break;
                    case "two":
                        Console.Write(2);
                        break;
                    case "three":
                        Console.Write(3);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
