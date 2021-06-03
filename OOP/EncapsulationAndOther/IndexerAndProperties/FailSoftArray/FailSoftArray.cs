namespace ConsoleApp4
{
    public class FailSoftArray
    {
        private int[] a;

        public int Length { get; private set; }
        public bool Error { get; private set; }

        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }
        
        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index))
                {
                    a[index] = value;
                    Error = false;
                }
                else
                    Error = true;
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
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
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
                    Error = false;
                }
                else
                {
                    Error = true;
                }

            }
        }
        
        private bool Ok(int index)
        {
            return (index >= 0 & index < Length);
        }
        
    }
}
