using System;

namespace ConsoleApp4
{
    class FSDemo
    {
        static void Main()
        {
            FailSoftArray fs = new FailSoftArray(5);
            for (int i = 0; i < fs.Length + 1; i++)
            {
                fs[i] = i * 10;
                if (fs.Error)
                    Console.WriteLine("Error in the index " + i);
            }
            
        }
    }
}
