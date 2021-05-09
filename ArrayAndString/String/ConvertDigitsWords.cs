using System;

namespace ConsoleApp3
{
    class ConvertDigitsWords
    {
        static void Main()
        {
            int num = 1908;
            int numDigit = 0;
            int[] n = new int[20];
            string[] digits = {"zero", "one", "two", "three", "four", "fifth", "six", "seven", "eight", "nine"};
            Console.WriteLine("Num:" + num);
            Console.WriteLine("Number to word:");
            do
            {
                int nextDigit = num % 10;
                n[numDigit] = nextDigit;
                numDigit++;
                num /= 10;
            } while (num > 0); // 8 0 9 1

            numDigit--;
            for (; numDigit >= 0; numDigit--)
                Console.Write(digits[n[numDigit]] + " ");
            Console.WriteLine();
        }
    }
}
