namespace ConsoleApp4
{
    public class SimpProp
    {
        private int prop;

        public SimpProp()
        {
            prop = 0;
        }

        public int MyProp
        {
            get
            {
                return prop;
            }
            set
            {
                if (value >= 0) prop = value;
            }
        }
    }
}
