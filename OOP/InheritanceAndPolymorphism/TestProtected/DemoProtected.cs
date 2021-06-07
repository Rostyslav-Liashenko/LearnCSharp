using ConsoleApp6.TestProtected;

namespace ConsoleApp6
{
    class ProtectedDemo
    {
        static void Main()
        {
            D ob = new D();
            ob.Set(2,3);
            ob.Show();
            ob.Setk();
            ob.ShowK();
        }
    }
}
