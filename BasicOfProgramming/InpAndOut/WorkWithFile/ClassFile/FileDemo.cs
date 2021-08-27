using System;
using System.IO;

namespace LearnWorkWithFile
{
    static class FileDemo
    {
        static void Main()
        {
            string path = "/home/kivi27/LearnCSharp/BasicOfProgramming/InpAndOut/WorkWithFile/BinaryStream/test.cs";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine($"Name file: {fileInf.Name}");
                Console.WriteLine($"Time to create: {fileInf.CreationTime}");
                Console.WriteLine($"Size: {fileInf.Length}");
                fileInf.CopyTo("/home/kivi27/LearnCSharp/BasicOfProgramming/InpAndOut/WorkWithFile/test.cs",true);
                File.Delete("/home/kivi27/LearnCSharp/BasicOfProgramming/InpAndOut/WorkWithFile/test.cs");
            }
            
        }
    }
}
