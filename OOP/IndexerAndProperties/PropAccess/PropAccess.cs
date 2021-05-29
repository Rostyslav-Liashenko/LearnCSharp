
namespace ConsoleApp4
{
    public class PropAccess
    {
        private int prop;

        public PropAccess()
        {
            prop = 0;
        }

        public int MyProp
        {
            get
            {
                return prop;
            }
            private set
            {
                prop = value;
            }
        }

        public void IncrProp()
        {
            MyProp++;
        }
        
    }
}
