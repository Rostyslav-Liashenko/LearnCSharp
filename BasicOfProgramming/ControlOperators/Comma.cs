using System;

namespace ConsoleApp1
{
    class Comma
    {
        static void Main()
        {
            int i, j;
            int smallest = 1, largest = 1;
            int num = 100;
            for (i = 2, j = num / 2; (i <= num /2) && (j >= 2); i++, j--)
            {
                if ((smallest == 1) && (num % i) == 0)
                    smallest = i;
                if ((largest == 1) && (num % j) == 0)
                    largest = j;
            }
            Console.WriteLine("smallest = " + smallest);
            Console.WriteLine("largest = " + largest);
        }
    }
}
