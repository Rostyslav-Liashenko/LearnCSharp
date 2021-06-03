using System;

namespace ConsoleApp4
{
    public class Cons
    {
        private static int alpha;
        private int beta;

        static Cons()
        {
            alpha = 99;
            Console.WriteLine("In static constructor");
        }

        public static int GetAlpha()
        {
            return alpha;
        }

        public int GetBetta()
        {
            return beta;
        }
        public Cons()
        {
            beta = 100;
            Console.WriteLine("In constructor object classes");
        }

    }
}
