using System;
using System.Net;
using System.IO;

namespace LearnNetwork
{
    class NetDemo
    {
        static void Main()
        {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://www.McGraw-Hill.com");
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Stream istrm = resp.GetResponseStream();
            for (int i = 1;; i++)
            {
                var ch = istrm.ReadByte();
                if (ch == -1) break;
                Console.Write((char) ch);
                if (i % 400 == 0)
                {
                    Console.WriteLine("\nPress key <Enter>.");
                    Console.ReadLine();
                }
            }
            resp.Close();
        }
    }
}
