using System;
using System.Collections;
using System.Linq;

namespace LearnCollections
{
    class ArrayListToArray
    {
        static void Main()
        {
            ArrayList al = new ArrayList { 1, 2, 3, 4 };
            int[] ia = (int[]) al.ToArray(typeof(int));
            Console.WriteLine("Summa = " + ia.Sum());
        }
    }
}
