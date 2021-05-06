using System;

namespace ConsoleApp3
{
    class TwoD
    {
        static void Main()
        {
            int[,] table = new int[3, 4];
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    table[i, j] = (i * 4) + j + 1;
                    Console.Write(table[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
