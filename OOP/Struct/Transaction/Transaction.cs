using System;

namespace LearnStructure
{
    public class Transaction
    {
        private static uint transacNum = 0;
        private PacketHeader ph;
        private string accountNum;
        private double amount;

        public Transaction(string acc, double val)
        {
            ph.PackNum = transacNum++;
            ph.PackLen = 512; // random length of packet
            accountNum = acc;
            amount = val;
        }

        public void SendTransaction()
        {
            Console.WriteLine("Packet #: " + ph.PackNum +
                               ", Length: " + ph.PackLen +
                               ", Account #:" + accountNum+
                               ", Summa: " + amount);
        }
    }
}
