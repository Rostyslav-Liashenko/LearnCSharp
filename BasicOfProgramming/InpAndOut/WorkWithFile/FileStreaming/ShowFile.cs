using System;
using System.IO;

namespace LearnInpAndOut
{
    class ShowFile
    {
        public static void Main()
        {
            FileStream fin;
            Console.WriteLine("Input the name of file:");
            string nameFile = Console.ReadLine();
            try
            {
                fin = new FileStream(nameFile, FileMode.Open);
            }
            catch (IOException exc)
            {
                Console.Write("Not open file");
                Console.WriteLine(exc.Message);
                return;
            }

            try
            {
                int i;
                do
                { 
                    i = fin.ReadByte();
                    if (i != -1) Console.Write((char) i);
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error read file");
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fin.Close();
            }
        }
    }
}
