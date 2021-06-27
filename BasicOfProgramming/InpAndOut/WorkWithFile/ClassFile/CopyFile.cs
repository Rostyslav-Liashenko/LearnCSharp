using System;
using System.IO;

namespace LearnInpAndOut
{
    class CopyFile
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Note: CopyFile not found two arguments");
                return;
            }
            try
            {
                File.Copy(args[0], args[1], true);
            }
            catch (IOException exc)
            {
               Console.WriteLine("Error copy file\n" + exc.Message); 
            }
        }
    }
}
