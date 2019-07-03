using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testXml
{
    public class XDocumentDemo
    {
        public void Test1(string xml, string code)
        {
            XDocument document = XDocument.Parse(xml);
            string str = document.Element("xml").Element(code).Value;
            Console.WriteLine(str);
        }
        public void Test2(string xml, string code)
        {
            XDocument document = XDocument.Parse(xml);
            string str = document.Element(code).Value;
            Console.WriteLine(str);
        }
    }
}
