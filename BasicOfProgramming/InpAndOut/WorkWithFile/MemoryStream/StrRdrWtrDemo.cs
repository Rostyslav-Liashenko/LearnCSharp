using System;
using System.IO;

namespace LearnInpAndOut
{
    class StrRdrWtrDemo
    {
        public static void Main()
        {
            StringWriter strwtr = null;
            StringReader strrdr = null;
            try
            {
                strwtr = new StringWriter();
                for (int i = 0; i < 10; i++)
                    strwtr.WriteLine("Value i equals: " + i);
                strrdr = new StringReader(strwtr.ToString());
                string str = strrdr.ReadLine();
                while (str != null)
                {
                    str = strrdr.ReadLine();
                    Console.WriteLine(str);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output:\n" + exc.Message);
            }
            finally
            {
                if (strrdr != null) strrdr.Close();
                if (strwtr != null) strwtr.Close();
            }
        }
    }
}
