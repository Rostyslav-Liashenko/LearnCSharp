#define EXPERIMENTAL
using System;

namespace LearnPreprosseccor
{
    class TestDefineIfEndif
    {
        static void Main()
        {
            #if EXPERIMENTAL
                Console.WriteLine("Compiler for experimental version");
            #endif
            Console.WriteLine("Have in all version");
        }
    }
}
