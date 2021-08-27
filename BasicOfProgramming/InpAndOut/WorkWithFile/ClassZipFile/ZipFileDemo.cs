using System;
using System.IO.Compression;

namespace LearnWorkWithFile
{
    static class ZipFileDemo
    {
        static void Main()
        {
            string sourceFolder = "/home/kivi27/Test";
            string zipFile = "/home/kivi27/Test.zip";
            string targetFolder = "/home/kivi27/NewTest";
            
            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            ZipFile.ExtractToDirectory(zipFile, targetFolder);
            Console.WriteLine("Completed!");
        }
    }
}
