namespace ConsoleApp5
{
    class MainProgram
    {
        static int Main()
        {
            Phone ph1 = new Phone();
            ph1.PrintAllInfo();
            Phone ph2 = new Phone("+380677670069", "xiaomi note 7", 0.540);
            ph2.PrintAllInfo();
            ph2.ReceiveCall("Jim","0931803019");
            ph2.ReceiveCall("Anna");
            ph2.SendMessage("0677670059","0931803014","0677670057");
            return 0;
        }
    }
}
