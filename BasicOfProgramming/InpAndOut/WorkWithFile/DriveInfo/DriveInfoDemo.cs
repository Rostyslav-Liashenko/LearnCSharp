using System;
using System.IO;

namespace LearnWorkWithFile
{
    static class DriveInfoDemo
    {
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Volume of disk: {drive.TotalSize}");
                    Console.WriteLine($"Total free Space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Label: {drive.VolumeLabel}");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
