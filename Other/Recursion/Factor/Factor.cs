namespace ConsoleApp4
{
    public class Factor
    {
        public int FactR(int n)
        {
            if (n == 1 || n == 0) return 1;
            return FactR(n - 1) * n;
        }

        public int FactI(int n)
        {
            int result = 1;
            for (int t = 1; t <= n; t++)
                result *= t;
            return result;
        }
    }
}
