using System;

namespace ConsoleApp3
{
    class Jagged
    {
        static void Main()
        {
            int[][] networkNodes = new int[4][];
            networkNodes[0] = new int[3];
            networkNodes[1] = new int[7];
            networkNodes[2] = new int[2];
            networkNodes[3] = new int[5];
            // fake data
            for (int i = 0; i < networkNodes.Length; i++)
                for (int j = 0; j < networkNodes[i].Length; j++)
                    networkNodes[i][j] = i * j + 70;
            Console.WriteLine("Total number network nodes:" + networkNodes.Length + "\n");
            for (int i = 0; i < networkNodes.Length; i++)
            {
                for (int j = 0; j < networkNodes[i].Length; j++)
                {
                    Console.Write("use in network " + i +" CPU " + j + ":");
                    Console.Write(networkNodes[i][j] + "% ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
                
        }
    }
}
