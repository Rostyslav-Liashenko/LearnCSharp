using System;
using System.Text.RegularExpressions;

namespace LearnFeatures
{
    static class RegularDemo
    {
        static void Main()
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            else
                Console.WriteLine("Match not found");
            s = "456-435-2318";
            regex = new Regex(@"\d{3}-\d{3}-\d{4}"); 
            matches = regex.Matches(s);
            if (matches.Count > 0)
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            else
                Console.WriteLine("Match not found");
        }
    }
}
