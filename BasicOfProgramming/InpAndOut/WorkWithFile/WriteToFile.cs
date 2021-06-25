using System;
using System.IO;

namespace LearnInpAndOut
{
    class WriteToFile
    {
        public static void Main()
        {
            FileStream fout = null;
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
                for (char c = 'A'; c <= 'Z'; c++)
                    fout.WriteByte((byte) c);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error input and output:\n" + e.Message);
            }
            finally
            {
                if (fout != null) fout.Close();
            }
        }
    }
}
