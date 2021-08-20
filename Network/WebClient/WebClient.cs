using System;
using System.Net;

namespace LearnNetwork
{
    class WebClientDemo
    {
        static void Main()
        {
            WebClient user = new WebClient();
            string uri = "http://www.McGraw-Hill.com";
            string fname = "data.txt";
            try
            {
                Console.WriteLine("Download data from address " + uri + " in file " + fname);
                user.DownloadFile(uri, fname);
            }
            catch (WebException exc)
            {
                Console.WriteLine(exc);
            }
            Console.WriteLine("Download is completed.");
        }
    }
}
