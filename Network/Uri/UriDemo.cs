using System;

namespace LearnNetwork
{
    class UriDemo
    {
        static void Main()
        {
            Uri sample = new Uri("http://HerShildt.com/somefile.txt?SomeQuery");
            Console.WriteLine("Host: " + sample.Host);
            Console.WriteLine("Port: " + sample.Port);
            Console.WriteLine("Protocol: " + sample.Scheme);
            Console.WriteLine("Local path: " + sample.LocalPath);
            Console.WriteLine("Query: " + sample.Query);
            Console.WriteLine("Path and query:" + sample.PathAndQuery);
        }
    }
}
