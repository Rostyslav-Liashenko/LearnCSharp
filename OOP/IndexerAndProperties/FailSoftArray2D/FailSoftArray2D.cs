namespace ConsoleApp4
{
    public class FailSoftArray2D
    {
        private int[,] a;
        private int rows, cols;
        private int length;
        private bool errFlag;

        public FailSoftArray2D(int r, int c)
        {
            rows = r;
            cols = c;
            a = new int[rows, cols];
            length = rows * cols;
        }

        public int GetLength()
        {
            return length;
        }

        public bool GetErrFlag()
        {
            return errFlag;
        }

        private bool Ok(int index1, int index2)
        {
            return (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols);
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (Ok(index1, index2))
                {
                    errFlag = false;
                    return a[index1, index2];
                }
                else
                {
                    errFlag = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index1, index2))
                {
                    a[index1, index2] = value;
                    errFlag = false;
                }
                else
                    errFlag = true;
            }
        }
    }
}
