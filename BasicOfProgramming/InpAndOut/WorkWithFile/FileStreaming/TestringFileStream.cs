using System;
using System.IO;

namespace LearnInpAndOut
{
    class TestingFileStream
    {
        public static void Main()
        {
            const byte maxElement = 5;
            byte[] array = new byte[maxElement];
            FileStream file = null;
            Console.WriteLine("Input the " +  maxElement + " numbers for write in file");
            for (int i = 0; i < maxElement; i++)
                array[i] = Convert.ToByte(Console.ReadLine());
            try
            {
                file = new FileStream("text1.dat", FileMode.Create);
                file.Write(array, 0, 5);
                Console.WriteLine("File is ready!!!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Sorry, I catch exception is\n" + e.Message);
            }
            finally
            {
                file.Close();
            }
        }
    }
}
