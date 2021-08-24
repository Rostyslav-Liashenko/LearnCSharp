using System;

namespace LearnFeatures
{
    static class PositionDemo
    {
        static string GetWelcome(MessageDetails details) => details switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            _ => "Hell0"
        };

        static  void Main()
        {
          MessageDetails details1 = new MessageDetails { Language = "english", DataTime = "evening", Status = "user" };
          Console.WriteLine(GetWelcome(details1));
          MessageDetails details2 = new MessageDetails { Language = "french", DataTime = "morning", Status = "admin" };
          Console.WriteLine(GetWelcome(details2));
        }
    }
}
