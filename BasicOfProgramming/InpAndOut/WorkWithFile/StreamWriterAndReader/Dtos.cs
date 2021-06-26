using System;
using System.IO;

namespace LearnInpAndOut
{
    class Dtos
    {
        public static void Main()
        {
            FileStream fin = null;
            try
            { 
                fin = new FileStream("test.txt", FileMode.Open);
            }
            catch (IOException)
            {
                Console.WriteLine("Error! File not open;");
            }
            StreamReader fstrIn = new StreamReader(fin);
            try
            {
                string s;
                while (fstrIn.EndOfStream)
                {
                    s = fstrIn.ReadLine();
                    Console.WriteLine(s);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input and output:" + exc.Message);
            }
            finally
            {
                fstrIn.Close();
            }
        }
    }
}
