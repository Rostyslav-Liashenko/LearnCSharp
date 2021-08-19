using System;
using System.Net;
using System.IO;

namespace LearnNetwork
{
    class NetExcDemo
    {
        static void Main()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest) WebRequest.Create("http://www.McGraw-Hill.com/moonrocket");
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
            catch (WebException exc)
            {
                Console.WriteLine("Network error: " + exc.Message +
                                  "\nCode status: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Protocol error: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("Error format URI: " + exc.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("I don't know this protocol...");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error input-output: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                Console.WriteLine("Error in security: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Not available operation: " + exc.Message);
            }
        }
    }
}
