using System;
using System.IO;

namespace LearnInpAndOut
{
    class RWData
    {
        public static void Main()
        {
            BinaryWriter dataOut = null;
            BinaryReader dataIn;

            int i = 10;
            double d = 1023.56;
            bool b = true;
            string str = "It is test";

            try
            {
                dataOut = new BinaryWriter(new FileStream("testdata", FileMode.Create));
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error!\n" + exc.Message);
                return;
            }

            try
            {
                Console.WriteLine("Record " + i);
                dataOut.Write(i);
                Console.WriteLine("Record " + d);
                dataOut.Write(d);
                Console.WriteLine("Record " + b);
                dataOut.Write(b);
                Console.WriteLine("Record " + 12.2 * 7.4);
                dataOut.Write(12.2 * 7.4);
                Console.WriteLine("Record " + str);
                dataOut.Write(str);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error!\n" + exc.Message);
            }
            finally
            {
                dataOut.Close();
            }
            Console.WriteLine();
            try
            {
                dataIn = new BinaryReader(new FileStream("testdata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!\n" + e.Message);
                return;
            }

            try
            {
                i = dataIn.ReadInt32();
                Console.WriteLine("Read " + i);
                d = dataIn.ReadDouble();
                Console.WriteLine("Read " + d);
                b = dataIn.ReadBoolean();
                Console.WriteLine("Read " + b);
                d = dataIn.ReadDouble();
                Console.WriteLine("Read " + d);
                str = dataIn.ReadString();
                Console.WriteLine("Read " + str);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error inp-out:\n" + e.Message);
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}
