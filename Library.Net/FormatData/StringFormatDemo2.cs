using System;

namespace LearnLibrary
{
    class StringFormatDemo2
    {
        static void Main()
        {
            int sum = 0;
            int prod = 1;
            string str;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                prod *= i;
                str = String.Format("Summa:{0,3:D} Production:{1,8:D}", sum, prod);
                Console.WriteLine(str);
            }
        }
    }
}
