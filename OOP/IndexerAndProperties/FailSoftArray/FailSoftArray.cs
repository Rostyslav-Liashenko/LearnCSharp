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

        public int this[double idx]
        {
            get
            {
                int index;
                if (idx - (int) idx < 0.5)
                    index = (int) idx;
                else
                    index = (int) (idx) + 1;
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
                int index;
                if (idx - (int) idx < 0.5)
                    index = (int) idx;
                else
                    index = (int) (idx) + 1;
                if (Ok(index))
                {
                    a[index] = value;
                    errFlag = false;
                }
                else
                {
                    errFlag = true;
                }

            }
        }
        
        private bool Ok(int index)
        {
            return (index >= 0 & index < length);
        }
        
    }
}
