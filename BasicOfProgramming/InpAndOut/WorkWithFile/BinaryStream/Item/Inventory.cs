using System;
using System.IO;

namespace LearnInpAndOut
{
    class Inventory
    {
        public static void Main()
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;
            try
            {
                dataOut = new BinaryWriter(new FileStream("inventory.dat", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!\n" + e.Message);
                return;
            }
            Item[] arrayItem = new Item[3];
            arrayItem[0] = new Item("Milk", 20, 12.45);
            arrayItem[1] = new Item("Fish", 12, 24.50);
            arrayItem[2] = new Item("Meat", 10, 32.50);
            try
            {
                foreach (Item oneItem in arrayItem)
                    oneItem.RecordInBinaryFile(dataOut);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!\n" + e.Message);
            }
            finally
            {
                dataOut.Close();
            }
            Console.WriteLine();
            try
            {
                dataIn = new BinaryReader(new FileStream("inventory.dat", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!\n" + e.Message);
                return;
            }
            Console.WriteLine("Input the name of item:");
            string what = Console.ReadLine();
            try
            {
                Item tmp;
                for (int i = 0; i < arrayItem.Length; i++)
                { 
                    tmp = Item.LoadFromBinaryFile(dataIn); 
                    if (tmp.NameItem == what)
                    {
                        Console.WriteLine(tmp);
                        break;
                    }
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("Item not found");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error read file");
                Console.WriteLine("Reason: " + exc.Message);
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}
