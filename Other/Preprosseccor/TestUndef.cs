#define SMALL
#undef SMALL
using System;

namespace LearnPreprosseccor
{
    class AllDirective
    {
        static void Main()
        {
            #if SMALL
                Console.WriteLine("Define Small");
            #endif
        }
    }
}
