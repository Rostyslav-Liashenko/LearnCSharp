using System;

namespace LearnException
{
    class OrderMatters
    {
        public static void Main()
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0)
                        throw new ExceptA("Throw exception type ExceptA");
                    else if (x == 1)
                        throw new ExceptB("Throw exception type ExceptB");
                    else
                        throw new Exception();
                }
                catch (ExceptB ecx)
                {
                    Console.WriteLine(ecx);
                }
                catch (ExceptA exc)
                {
                    Console.WriteLine(exc);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
        }
    }
}
