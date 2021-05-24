namespace ConsoleApp4
{
    public class FailSoftArray
    {
        private int[] a;
        private int length;
        private bool errFlag;

        public FailSoftArray(int size)
        {
            a = new int[size];
            length = size;
        }

        public bool GetErrFlag()
        {
            return errFlag;
        }
        public int GetLength()
        {
            return length;
        }
        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    errFlag = false;
                    return a[index];
                }
                else
                {
                    errFlag = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index))
                {
                    a[index] = value;
                    errFlag = false;
                }
                else
                    errFlag = true;
            }
        }
        
        private bool Ok(int index)
        {
            return (index >= 0 & index < length);
        }
        
    }
}
