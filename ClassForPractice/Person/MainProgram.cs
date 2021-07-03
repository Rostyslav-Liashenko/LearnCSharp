namespace ConsoleApp5
{
    class MainProgram
    {
        static int Main()
        {
            Person john = new Person();
            Person marry = new Person("Merry", 25);
            john.GetInfo();
            marry.GetInfo();
            marry.Move();
            marry.Talk();
            return 0;
        }
    }
}
