using System;
using System.IO;

namespace LearnInpAndOut
{
    class KtoD
    {
        public static void Main()
        {
            string str;
            FileStream fout = null;
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error open the file!\n" + e.Message);
            }
            StreamWriter fstrOut = new StreamWriter(fout);
            try
            {
                Console.WriteLine("Input the text for the end type stop");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();
                    if (str != "stop")
                        fstrOut.WriteLine(str);
                } while (str != "stop");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output:\n" + exc.Message);
            }
            finally
            {
                fstrOut.Close();
            }
        }
    }
}
