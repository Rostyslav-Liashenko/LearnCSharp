namespace LearnLINQ
{
    class SimpQuery
    { 
        static void Main()
        {
            int[] nums = {1, -2, 3, 0, -4, 5};
            var posNums = from n in nums where n > 0
                select n;
            Console.WriteLine("Positive value from array nums");
            foreach(int i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
            nums[1] = 99;
            Console.WriteLine("Positive value from array nums, When I modify array");
            foreach(int i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
