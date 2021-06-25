using System;
using System.IO;

namespace LearnInpAndOut
{
    class CopyFile
    {
        public static void Main()
        {
            FileStream fin = null;
            FileStream fout = null;
            Console.WriteLine("Input the name first file: ");
            string nameInFile = Console.ReadLine();
            Console.WriteLine("Input the second name file: ");
            string nameOutFile = Console.ReadLine();
            try
            {
                fin = new FileStream(nameInFile, FileMode.Open);
                fout = new FileStream(nameOutFile, FileMode.Create);
                int i;
                do
                {
                    i = fin.ReadByte();
                    if (i != -1) fout.WriteByte((byte) i);
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input and output:\n " + exc.Message);
            }
            finally
            {
                if (fin != null)
                    fin.Close();
                if (fout != null)
                    fout.Close();
            }
        }
    }
}
