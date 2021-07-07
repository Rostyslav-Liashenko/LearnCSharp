#define RELEASE

using System;

namespace LearnPreprosseccor
{
    class TestDefineIfEndif2
    {
        static void Main()
        {
            #if EXPERIMENTAL
                Console.WriteLine("Compiler for experimental version");
            #elif RELEASE
                Console.WriteLine("Compiler for end version");
            #else 
                Console.WriteLine("Compiler for insert testing");
            #endif
            #if EXPERIMENTAL && TRIAL
                Console.WriteLine("Check trial experimental version");
            #else 
                Console.WriteLine("It is not trial version");
            #endif
            Console.WriteLine("Have in all version");
        }
    }
}
