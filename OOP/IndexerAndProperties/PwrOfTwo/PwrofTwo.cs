using System;

namespace ConsoleApp4
{
    public class PwrOfTwo
    {
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < 16)
                    return (int) Math.Pow(2, index);
                else
                    return -1;
            }
        }
    }
}
