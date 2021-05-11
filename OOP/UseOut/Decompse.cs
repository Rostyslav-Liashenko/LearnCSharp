namespace ConsoleApp3
{
    public class Decompose
    {
        public int GetParts(double n, out double frac)
        {
            int whole = (int) n;
            frac = n - whole;
            return whole;
        }
    }
}
