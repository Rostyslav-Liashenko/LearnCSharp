using System;
using System.IO;

namespace LearnInpAndOut
{
    class MemStrDemo
    {
        public static void Main()
        {
            byte[] storage = new byte[255];
            MemoryStream memstrm = new MemoryStream(storage);
            StreamWriter memwtr = new StreamWriter(memstrm);
            StreamReader memrder = new StreamReader(memstrm);
            try
            {
                for (int i = 0; i < 10; i++)
                    memwtr.WriteLine("byte [" + i + "]: " + i);
                memwtr.WriteLine(".");
                memwtr.Flush();
                Console.WriteLine("Read from array storage: ");
                foreach (char ch in storage)
                {
                    if (ch == '.')
                        break;
                    Console.Write(ch);
                }
                Console.WriteLine("Read from stream with help object memrder:" );
                memstrm.Seek(0, SeekOrigin.Begin);
                string str = memrder.ReadLine();
                while (str != null)
                {
                    str = memrder.ReadLine();
                    if (str[0] == '.')
                        break;
                    Console.WriteLine(str);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output:\n" + exc.Message);
            }
            finally
            {
                memstrm.Close();
                memrder.Close();
            }
        }
    }
}
