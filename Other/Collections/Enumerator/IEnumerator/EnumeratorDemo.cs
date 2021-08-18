using System;
using System.Collections;

namespace LearnCollections
{
    static class EnumeratorDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
                list.Add(i);
            IEnumerator etr = list.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
        }
    }
}
