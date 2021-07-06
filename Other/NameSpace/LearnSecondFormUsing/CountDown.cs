namespace Counter
{
    public class CountDown
    {
        private int val;

        public CountDown(int n)
        {
            val = n;
        }

        public void Reset(int n)
        {
            val = n;
        }

        public int Count()
        {
            if (val > 0) return val--;
            else return 0;
        }
        
    }
}
