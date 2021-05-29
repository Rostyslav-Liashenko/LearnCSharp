using System;

namespace ConsoleApp4
{
    public class RangeArray
    {
        private int[] a;
        private int lowerBound;
        private int upperBound;

        public int Length { get; private set; }
        public bool Error { get; private set; }

        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                Console.WriteLine("Wrong index");
                high = 1;
                low = 0;
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
                {
                    Error = false;
                    return a[index - lowerBound];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set
            {
                if (Check(index))
                {
                    a[index - lowerBound] = value;
                    Error = false;
                }
                else
                    Error = true;
            }
            
        }

        private bool Check(int index)
        {
            return (index >= lowerBound && index <= upperBound);
        }
        
    }
}
