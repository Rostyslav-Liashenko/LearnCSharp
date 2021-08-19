using System;
using System.Net;

namespace LearnNetwork
{
    class CookieDemo
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("You need use: CookieDemo <uri>");
                return;
            }

            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(args[0]);
            req.CookieContainer = new CookieContainer();
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Console.WriteLine("Count cookie-set: " + resp.Cookies.Count);
            Console.WriteLine("{0,-20} {1}","Name","Value");
            for (int i = 0; i < resp.Cookies.Count; i++)
                Console.WriteLine("{0,-20} {1}", resp.Cookies[i].Name, resp.Cookies[i].Value);
            resp.Close();
        }
    }
}
