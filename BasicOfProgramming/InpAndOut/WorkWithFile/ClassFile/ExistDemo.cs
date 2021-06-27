using System;
using System.IO;

namespace LearnInpAndOut
{
    class ExistDemo
    {
        public static void Main(string[] args)
        {
            if (File.Exists(args[0]))
                Console.WriteLine("Last time it was available: " + File.GetLastAccessTime(args[0]));
            else 
                Console.WriteLine("File not found!!!");
        }
    }
}
