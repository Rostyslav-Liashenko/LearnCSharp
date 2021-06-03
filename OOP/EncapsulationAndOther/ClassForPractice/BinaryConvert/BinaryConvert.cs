using System;

namespace ConsoleApp5.BinaryConvert
{
    public static class BinaryConvert
    {
        private static string ReverseCode(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
                newStr += str[i];
            return newStr;
        }
        public static string ToBinary(int number)
        {
            string binaryCode = "";
            while (number >= 2)
            {
                binaryCode += (number % 2).ToString();
                number /= 2;
            }
            binaryCode += number;
            binaryCode = ReverseCode(binaryCode);
            return binaryCode;
        }

        public static int ToDecimal(string binaryCode)
        {
            int number = 0;
            binaryCode = ReverseCode(binaryCode);
            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    number += (int) Math.Pow(2, i);
                }
            }

            return number;
        }
    }
}
