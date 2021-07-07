#define EXPERIMENTAL
#define TRIAL

using System;

namespace LearnPreprosseccor
{
    class TestDefineIfEndif2
    {
        static void Main()
        {
            #if EXPERIMENTAL
                Console.WriteLine("Compiler for experimental version");
            #endif
            #if EXPERIMENTAL && TRIAL
                Console.WriteLine("Check trial experimental version");
            #endif
            Console.WriteLine("Have in all version");
        }
    }
}
