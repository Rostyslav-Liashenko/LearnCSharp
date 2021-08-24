using System;

namespace LearnFeatures
{
    static class Properties
    {
        static string GetMessage(Person p) => p switch
        {
            { Language: "english" } => "Hello!",
            { Language: "german", Status: "admin", Name: var name } => $"Hallo, admin. You name: {name}",
            {Language: "french", Name: var name} => $"Salut, {name}!",
            {Language: var lang} => $"unknown language, {lang}",
        };
        
        static  void Main()
        {
            Person pierre = new Person {Language = "french", Status = "user", Name = "Pierre"};
            string message = GetMessage(pierre);
            Console.WriteLine(message);

            Person tomas = new Person {Language = "german", Status = "admin", Name = "Tomas"};
            Console.WriteLine(GetMessage(tomas));

            Person pablo = new Person {Language = "spanish", Status = "user", Name = "Pablo"};
            Console.WriteLine(GetMessage(pablo));
        }
    }
}
