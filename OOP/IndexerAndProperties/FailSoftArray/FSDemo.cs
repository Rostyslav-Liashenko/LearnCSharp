using System;

namespace ConsoleApp4
{
    class FSDemo
    {
        static void Main()
        {
            int x;
            FailSoftArray fs = new FailSoftArray(5);
            Console.WriteLine("Latent failure.");
            for (int i = 0; i < (fs.GetLength() * 2); i++)
                fs[i] = i * 10;
            for (int i = 0; i < (fs.GetLength() * 2); i++)
            {
                x = fs[i];
                if (x != -1) Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Crash with error notification.");
            for (int i = 0; i < (fs.GetLength() * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.GetErrFlag())
                    Console.WriteLine("fs[" + i + "] in out range");
            }

            for (int i = 0; i < (fs.GetLength() * 2); i++)
            {
                x = fs[i];
                if (!fs.GetErrFlag()) 
                    Console.Write(x + " ");
                else 
                    Console.WriteLine("fs[" + i + "] out the range");
            }
            
            Console.WriteLine("fs[1.1] " + fs[1.1]);
            Console.WriteLine("fs[1.6] " + fs[1.6]);
        }
    }
}
