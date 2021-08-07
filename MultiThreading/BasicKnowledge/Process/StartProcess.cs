using System;
using System.Diagnostics;

namespace LearnThreading
{
    class StartProcess
    {
        static void Main()
        {
            Process newProc = Process.Start("firefox");
            Console.WriteLine("New process is start");
            newProc.WaitForExit();
            newProc.Close();
            Console.WriteLine("New process is finished");
        }
    }
}
