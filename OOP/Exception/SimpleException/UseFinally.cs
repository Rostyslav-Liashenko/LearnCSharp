using System;

namespace LearnException
{
    class UseFinally
    {
        private static void GenException(int what)
        {
            Console.WriteLine("Get " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        throw new DivideByZeroException();
                    case 1:
                        throw new IndexOutOfRangeException();
                    case 2:
                        return;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divided by zero");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No matching item found");
            }
            finally
            {
                Console.WriteLine("After exit with block try.");
            }
        }

        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                UseFinally.GenException(i);
                Console.WriteLine();
            }
        }
    }
}
