using System;

namespace ConsoleApp3
{
    class MakeObjects
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j);
                anotherOb.Show();
            }
        }
    }
}
