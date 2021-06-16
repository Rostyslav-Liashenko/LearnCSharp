using System;

namespace LearnException
{
    class NREDemo
    {
        public static void Main()
        {
            X p = new X(10);
            X q = null;
            int val;
            try
            {
                val = p.Add(q);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Exception NullReferenceException");
                Console.WriteLine("Bug fixes");
                q = new X(9);
                val = p.Add(q);
            }
            Console.WriteLine("value q = {0}",val);
        }
    }
}
