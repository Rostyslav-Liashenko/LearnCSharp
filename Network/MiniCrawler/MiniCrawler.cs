using System;
using System.IO;
using System.Net;

namespace LearnNetwork
{
    class MiniCrawler
    {
        static string FindLink(string htmlStr, ref int startLoc)
        {
            string uri = null;
            int i = htmlStr.IndexOf("href=\"http", startLoc, StringComparison.OrdinalIgnoreCase);
            if (i != -1)
            {
                int start = htmlStr.IndexOf('"', i) + 1;
                int end = htmlStr.IndexOf('"', start);
                uri = htmlStr.Substring(start, end - start);
                startLoc = end;
            }

            return uri;
        }
        
        
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("You need use: MiniCrawler <uri>");
                return;
            }

            string uriStr = args[0];
            HttpWebResponse resp = null;
            try
            {
                do
                {
                    Console.WriteLine("Following link " + uriStr);
                    HttpWebRequest req = (HttpWebRequest) WebRequest.Create(uriStr);
                    uriStr = null;
                    resp = (HttpWebResponse) req.GetResponse();
                    Stream istrm = resp.GetResponseStream();
                    StreamReader rdr = new StreamReader(istrm);
                    var str = rdr.ReadToEnd();
                    var curLoc = 0;
                    string link = null;
                    do
                    {
                        link = FindLink(str, ref curLoc);
                        if (link != null)
                        {
                            Console.WriteLine("Found link: " + link);
                            Console.WriteLine("Following the link, Find, Exit?");
                            var answer = Console.ReadLine();
                            if (string.Equals(answer, "Following", StringComparison.Ordinal))
                            {
                                uriStr = string.Copy(link);
                                break;
                            }
                            else if (string.Equals(answer, "Find", StringComparison.Ordinal))
                            {
                                Console.WriteLine("Find next link...");
                            }
                            else
                            {
                                Console.WriteLine("Not found link.");
                                break;
                            }
                        }
                    } while (link.Length > 0);
                    
                    if (resp != null)
                        resp.Close();
                } while (uriStr != null);
            }
            catch (WebException exc)
            {
                Console.WriteLine("Network error:" + exc.Message + "\nCode status: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Protocol error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("Error format URI: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine("Not available protocol: " + exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output: " + exc.Message);
            }
            finally
            {
                if (resp != null)
                    resp.Close();
            }
            Console.WriteLine("Exit from MiniCrawler.");
        }
    }
}
