using System;

namespace LearnFeatures
{
    static class NullDemo
    {
        static void Main()
        {
            SomeClass someClass = null;
            // Console.WriteLine(someClass.Name); // exception NullReferenceException
            Console.WriteLine(someClass?.Name); // there is no exception. Console is empty
        }
    }
}
