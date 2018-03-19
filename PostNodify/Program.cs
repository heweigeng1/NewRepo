﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PostNodify
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpWebRequestPost("http://localhost:6832/WxPay/Notify", "<xml><sign></sign></xml>");
            Post("http://localhost:6832/WxPay/Notify", "<xml><sign></sign></xml>");
            Console.WriteLine("post over");
            Console.ReadKey();
        }
        public static void HttpWebRequestPost(string url, string xml)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] data = encoding.GetBytes(xml);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.ContentType = "text/xml";
            webRequest.ContentLength = data.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            HttpWebResponse myResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            Console.WriteLine(reader.ReadToEnd());
        }
        public static async void Post(string url, string xml)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] data = encoding.GetBytes(xml);
            HttpClient hc = new HttpClient();
            ByteArrayContent bt = new ByteArrayContent(data);
            var response = await hc.GetAsync(url);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }

}