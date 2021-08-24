using System;

namespace LearnFeatures
{
    static class TupleDemo
    {
        static string GetWelcome(string lang, string dataTime) => (lang, dataTime) switch
        {
            ("english", "morning") => "Good morning",
            ("english", "evening") => "Good evening",
            ("german", "morning") => "Guten Morgen",
            ("german", "evening") => "Guten Abend",
            (_, "evening") => $"I don't know you language {lang}. But it now evening",
            _ => "Hello"
        };

        static  void Main()
        {
            Console.WriteLine(GetWelcome("english","evening"));
            Console.WriteLine(GetWelcome("german","morning"));
            Console.WriteLine(GetWelcome("russia","evening"));
        }
    }
}
