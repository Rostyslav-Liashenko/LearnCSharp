using System;
using System.IO;

namespace TestDifferentFeatures
{
    class TestDriveInfo
    {
        static int Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Volume disk: {drive.TotalSize}");
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                }
                Console.WriteLine();
            }

            return 0;
        }
    }
}
