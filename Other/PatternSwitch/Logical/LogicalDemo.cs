using System;

namespace LearnFeatures
{
    static class LogicalDemo
    {

        static string CheckAge(int age) => age switch
        {
            < 1 or > 100 => "Way, Way",
            >= 1 and < 18 => "Access is ban",
            _ => "Access is allowed"
        };
        
        static  void Main()
        {
            Console.WriteLine(CheckAge(200));
            Console.WriteLine(CheckAge(0));
            Console.WriteLine(CheckAge(17));
            Console.WriteLine(CheckAge(18));
        }
    }
}
