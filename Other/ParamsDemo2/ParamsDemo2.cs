namespace ConsoleApp3
{
    class ParamsDemo2
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            ob.ShowArgs("It is sequence number", 1, 2, 3, 4, 5);
            ob.ShowArgs("It is another sequence number", 17, 10);
        }
    }
}
