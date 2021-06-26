using System;
using System.IO;

namespace LearnInpAndOut
{
    class StatisticOfFile
    {
        public static void Main()
        {
            int countRow = 0;
            int countCharacter = 0;
            
            StreamReader file;
            try
            {
                file = new StreamReader("test.txt");
            }
            catch (IOException exc)
            { 
                Console.WriteLine("Error!\n" + exc.Message);
                return;
            }

            try
            {
                while (!file.EndOfStream)
                { 
                    string str = file.ReadLine();
                    countRow++;
                    if (str != null) countCharacter += str.Length;
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error!\n" + exc.Message);
            }
            finally
            {
                file.Close();
            }
            Console.WriteLine("Count row in file = " + countRow);
            Console.WriteLine("Count character in file = " + countCharacter);
        }
    }
}
