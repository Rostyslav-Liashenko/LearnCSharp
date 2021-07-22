using System;
using System.Globalization;

namespace LearnLibrary
{
    class TestSystemChar
    {
        static void Main()
        {
            string str = "it is simple test. $23";
            int i;
            for (i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " have");
                if (Char.IsDigit(str[i]))
                    Console.Write(" digit");
                if (Char.IsLetter(str[i]))
                    Console.Write(" letter");
                if (Char.IsLower(str[i]))
                    Console.Write(" lower case");
                if (Char.IsUpper(str[i]))
                    Console.Write(" upper case");
                if (Char.IsSymbol(str[i]))
                    Console.Write(" symbol");
                if (Char.IsSeparator(str[i]))
                    Console.Write(" separator");
                if (Char.IsWhiteSpace(str[i]))
                    Console.Write(" space");
                if (Char.IsPunctuation(str[i]))
                    Console.Write(" punctuation");
                Console.WriteLine();
            }
            Console.WriteLine("Sources string: "+ str);
            string newstr = "";
            for (i = 0; i < str.Length; i++) 
                newstr += Char.ToUpper(str[i], CultureInfo.CurrentCulture);
            Console.WriteLine("After metamorphism: " + newstr);
            
        }
    }
}
