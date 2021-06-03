namespace ConsoleApp4
{
    class MakeObjects
    {
        static void Main()
        {
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = MyClass.Factory(i, j);
                anotherOb.Show();
            }
        }
    }
}
