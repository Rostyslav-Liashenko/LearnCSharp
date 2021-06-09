namespace LearnInterfaceProperties
{
    public class ByTwos : ISeries
    {
        private int val;

        public ByTwos()
        {
            val = 0;
        }

        public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
}
