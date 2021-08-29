using System;
using System.Xml;

namespace LearnXML
{
    class XMLDemo
    {
        static void Main()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("/home/kivi27/MyUsers.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    XmlNode attr = xNode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }

                foreach (XmlNode childNode in xNode.ChildNodes)
                {
                    if (childNode.Name == "company")
                        Console.WriteLine($"Company: {childNode.InnerText}");
                    if (childNode.Name == "age")
                        Console.WriteLine($"Age: {childNode.InnerText}");
                }
                Console.WriteLine();
            }
        }
    }
}
