namespace ConsoleApp3
{
    public class Factor
    {
        public int[] FindFactors(int num, out int numFactors)
        {
            int[] facts = new int[80];
            int i,j;
            for(i = 2, j = 0; i < num / 2 + 1; i++)
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
            
            numFactors = j;
            return facts;
        }
    }
}
