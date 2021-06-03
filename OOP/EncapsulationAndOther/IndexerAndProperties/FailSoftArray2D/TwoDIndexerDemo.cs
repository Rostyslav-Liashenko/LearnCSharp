using System;

namespace ConsoleApp4
{
    class TwoDIndexerDemo
    {
        static void Main()
        {
            FailSoftArray2D fs = new FailSoftArray2D(3, 5);
            int x;
            Console.WriteLine("Latent failure.");
            for (int i = 0; i < 6; i++)
                fs[i, i] = i * 10;
            for (int i = 0; i < 6; i++)
            {
                x = fs[i, i];
                if (x != -1) 
                    Console.Write(x + " "); 
            } 
            Console.WriteLine();
            Console.WriteLine("Crash with error notification.");
            for (int i = 0; i < 6; i++)
            {
                fs[i, i] = i * 10;
                if (fs.GetErrFlag())
                    Console.WriteLine("fs["+ i + ", " + i + "] in out the range");
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                x = fs[i, i];
                if (!fs.GetErrFlag()) 
                    Console.Write(x + " ");
                else 
                    Console.WriteLine("fs["+ i + ", " + i + "] in out the range");
            } 
        }
    }
}
