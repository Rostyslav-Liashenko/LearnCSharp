using System;

namespace ConsoleApp4
{
    class RangeArrayDemo
    {
        static void Main()
        {
            RangeArray ra = new RangeArray(-5,5);
            RangeArray ra2 = new RangeArray(1,10);
            RangeArray ra3 = new RangeArray(-20,-12);
            Console.WriteLine("Length of ra: " + ra.Length);
            for (int i = -5; i <= 5; i++)
                ra[i] = i;
            Console.WriteLine("Content of ra");
            ra.Show();
            Console.WriteLine("Length of ra2: " + ra2.Length);
            for (int i = 1; i <= 10; i++)
                ra2[i] = i;
            Console.WriteLine("Content of ra2");
            ra2.Show();
            Console.WriteLine("Length of ra3: " + ra3.Length);
            for (int i = -20; i <= -12; i++) 
                ra3[i] = i;
            Console.WriteLine("Content of ra3");
            ra3.Show();
        }
    }
}
