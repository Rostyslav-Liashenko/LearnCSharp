using System;
using System.Net;

namespace LearnNetwork
{
    class HeadersDemo
    {
        static void Main()
        {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://www.McGraw-Hill.com");
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            string[] names = resp.Headers.AllKeys;
            Console.WriteLine("{0,-20} {1}\n", "name", "value");
            foreach (var n in names)
            {
              Console.Write("{0, -20}", n);
              foreach (var v in resp.Headers.GetValues(n))
                Console.WriteLine(v);
            }
            resp.Close();
        }
    }
}
