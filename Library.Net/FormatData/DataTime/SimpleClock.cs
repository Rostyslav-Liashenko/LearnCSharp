using System;

namespace LearnLibrary
{
    class SimpleClock
    {
        static void Main()
        {
            
            DateTime dt = DateTime.Now;
            int seconds = dt.Second;

            for (;;)
            {
                dt = DateTime.Now;
                if (seconds != dt.Second)
                {
                    seconds = dt.Second;
                    string t = dt.ToString("T");
                    if (dt.Minute == 0 && dt.Second == 0)
                        t += "\a";
                    Console.WriteLine(t);
                }
            }
        }
    }
}
