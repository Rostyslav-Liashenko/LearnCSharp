using System;
using System.Linq;

namespace LearnLINQ
{
    class BoolWhere2
    { 
        static void Main()
        {
            string[] strs =
            {
                ".com", ".net", "hsNameA.com",
                "hsNameB.net", "test", ".network",
                "hsNameC.net", "hsNameD.com"
            };
            var netAddrs = from addr in strs
                where addr.Length > 4 && addr.EndsWith(".net")
                select addr;
            foreach (var str in netAddrs)
                Console.Write(str + " ");
            Console.WriteLine();
        }
    }
}
