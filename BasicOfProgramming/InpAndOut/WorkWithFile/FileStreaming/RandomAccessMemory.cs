using System;
using System.IO;

namespace LearnInpAndOut
{
    class RandomAccessMemory
    {
        public static void Main()
        {
            FileStream f = null;
            char ch;
            try
            {
                f = new FileStream("random.dat", FileMode.Create);
                for (int i = 0; i < 26; i++)
                    f.WriteByte((byte) ('A' + i));
                f.Seek(0, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("First letter: " + ch);
                f.Seek(1, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Second letter: " + ch);
                f.Seek(4, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("5 letter: " + ch);
                Console.WriteLine();
                Console.WriteLine("Alphabet letters through one:");
                for (int i = 0; i < 26; i += 2)
                {
                    f.Seek(i, SeekOrigin.Begin); // f.Position = i;
                    ch = (char) f.ReadByte();
                    Console.Write(ch + " ");
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output:\n" + exc.Message);
            }
            finally
            {
                if (f != null) f.Close();
            }
        }
    }
}
