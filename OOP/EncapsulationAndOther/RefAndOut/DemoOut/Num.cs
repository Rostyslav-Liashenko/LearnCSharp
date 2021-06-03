namespace ConsoleApp3
{
    public class Num
    {
        public bool HasComFactor(int x, int y, out int least, out int greatest)
        {
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;
            for (int i = 2; i <= max / 2 + 1; i++)
            {
                if ((y % i) == 0 & ((x % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }

                    greatest = i;
                }
            }

            return least != 1;
        }
    }
}
