using System;
using System.Net;

namespace LearnNetwork
{
    class LastModifiedDemo
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("You need use: LastModifieddemo <uri>");
                return;
            }

            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(args[0]);
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Console.WriteLine("Last modified: " + resp.LastModified);
            resp.Close();
        }
    }
}
