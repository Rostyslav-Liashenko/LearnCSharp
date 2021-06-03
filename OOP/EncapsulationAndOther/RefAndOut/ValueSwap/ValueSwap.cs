namespace ConsoleApp3
{
    public class ValueSwap
    {
        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
