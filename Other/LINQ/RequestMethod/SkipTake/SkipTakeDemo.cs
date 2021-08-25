using System;
using System.Linq;

namespace LearnLINQ
{
    static class SkipTakeDemo
    {
        static void Main()
        {
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            var result = numbers.Skip(4).Take(3);
            foreach(var i in result)
                Console.Write($"{i} ");
            string[] teams = {"Barselona", "Bell", "Madrid", "Bows"};
            Console.WriteLine();
            var resultTeams = teams.SkipWhile(str => str.StartsWith("B"));
            foreach(var t in resultTeams)
                Console.Write($"{t} ");
        }
    }
}
