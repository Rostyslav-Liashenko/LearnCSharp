using System;

namespace LearnException
{
    public class RangeArray
    {
        private int[] a;
        private int lowerBound;
        private int upperBound;

        public int Length { get; private set; }

        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                throw new RangeArrayException("The subscript is not less than the upper one.");
            }

            a = new int[high - low];
            Length = high - low;
            lowerBound = low;
            upperBound = --high;
        }

        public void Show()
        {
            for (int i = 0; i < Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        public int this[int index]
        {
            get
            {
                if (Check(index))
                    return a[index - lowerBound];
                else
                    throw new RangeArrayException("boundary violation error");
            }
            set
            {
                if (Check(index))
                    a[index - lowerBound] = value;
                else
                    throw new RangeArrayException("boundary violation error");
            }
            
        }

        private bool Check(int index)
        {
            return (index >= lowerBound && index <= upperBound);
        }
        
    }
}
