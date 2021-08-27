using System;
using System.IO;

namespace LearnWorkWithFile
{
    static class DirectoryDemo
    {
        static void Main()
        {
            string dirName = @"/home/kivi27/LearnCSharp";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Sub directory: ");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (var s in dirs)
                    Console.WriteLine(s);
                Console.WriteLine();
                Console.WriteLine("File: ");
                string[] files = Directory.GetFiles(dirName);
                foreach (var s in files)
                    Console.WriteLine(s);
            }
            // create directory
            string newPath = dirName + "/NewDirectory";
            DirectoryInfo dirInfo = new DirectoryInfo(newPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                Console.WriteLine("NewDirectory is create");
            }
            // delete directory
            try
            {
                dirInfo = new DirectoryInfo(newPath);
                dirInfo.Delete(true);
                Console.WriteLine("NewDirectory is remove");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }

            Directory.CreateDirectory(dirName + "/SomeDir"); // create directory
            Directory.Move(dirName + "/SomeDir", dirName + "/NewSomeDir"); // rename or move
        }
    }
}
