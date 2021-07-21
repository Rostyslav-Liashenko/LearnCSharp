using System;
using System.Runtime.InteropServices;

namespace LearnPartical
{
    class ExternMeth
    {
        [DllImport("ExtMeth.dll")]
        public extern static int AbsMax(int a, int b);
        
        static void Main()
        {
            int max = AbsMax(-10, -20);
            Console.WriteLine(max);
        }
    }
}
