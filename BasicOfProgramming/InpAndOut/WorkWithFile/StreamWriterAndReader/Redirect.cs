using System;
using System.IO;

namespace LearnInpAndOut
{
    class Redirect
    {
        public static void Main()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("logFile.txt");
                Console.SetOut(sw);
                Console.WriteLine("Begin ...");
                string str = Console.ReadLine();
                Console.WriteLine(str + "\n" + " End ...");
            }
            catch (IOException e)
            {
                Console.WriteLine("Some Error!\n" + e.Message);
            }
            finally
            {
                if (sw != null) 
                    sw.Close();
            }
        }
    }
}
