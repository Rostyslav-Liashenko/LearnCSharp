using System;
namespace ConsoleApp3
{
    class StringDemo
    {
        static void Main()
        {
            char[] charArray = {'I','t',' ','i','s',' ', 's','t','r','i','n','g'};
            string str1 = new string(charArray);
            string str2 = "New string";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
