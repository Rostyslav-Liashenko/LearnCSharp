using System;

namespace LearnLibrary
{
    class TimeAndDateFormatDemo
    {
        static void Main()
        {
            DateTime dt = DateTime.Now;
            
            Console.WriteLine("Format d: {0:d}", dt);
            Console.WriteLine("Format D: {0:D}", dt);
            
            Console.WriteLine("Format t: {0:t}", dt);
            Console.WriteLine("Format T: {0:T}", dt);
            
            Console.WriteLine("Format f: {0:f}", dt);
            Console.WriteLine("Format F: {0:F}", dt);
            
            Console.WriteLine("Format g: {0:g}", dt);
            Console.WriteLine("Format G: {0:G}", dt);
            
            Console.WriteLine("Format m: {0:m}", dt);
            Console.WriteLine("Format M: {0:M}", dt);
            
            Console.WriteLine("Format o: {0:o}", dt);
            Console.WriteLine("Format O: {0:O}", dt);
            
            Console.WriteLine("Format r: {0:r}", dt);
            Console.WriteLine("Format R: {0:R}", dt);
            
            Console.WriteLine("Format s: {0:s}", dt);
            
            Console.WriteLine("Format u: {0:u}", dt);
            Console.WriteLine("Format U: {0:U}", dt);
            
            Console.WriteLine("Format y: {0:y}", dt);
            Console.WriteLine("Format Y: {0:Y}", dt);
        }
    }
}
