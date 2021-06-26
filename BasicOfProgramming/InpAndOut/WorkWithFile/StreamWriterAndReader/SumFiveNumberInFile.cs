using System;
using System.IO;

namespace LearnInpAndOut
{
    class SumFiveNumberInFile
    {
        public static void Main()
        {
            StreamWriter fOut;
            try
            {
                fOut = new StreamWriter("test.txt");
            }
            catch (IOException exception)
            {
                Console.WriteLine("Error!\n" + exception.Message);
                return;
            }
            Console.WriteLine("Input the 5 number:");
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());
                fOut.WriteLine(tmp);
                sum += tmp;
            }
            fOut.WriteLine("Summa: " + sum);
            fOut.Close();
        }
    }
}
