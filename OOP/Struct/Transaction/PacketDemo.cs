namespace LearnStructure
{
    class PacketDemo
    {
        static void Main()
        {
            Transaction t = new Transaction("31243", -100.12);
            Transaction t2 = new Transaction("AB4655", 345.25);
            Transaction t3 = new Transaction("8475-09", 9800.00);
            
            t.SendTransaction();
            t2.SendTransaction();
            t3.SendTransaction();
        }
    }
}
