using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要切割文件的路径.");
            string path = Console.ReadLine();

            //Console.WriteLine("要切割文本行数");
            //int count;
            //while (true)
            //{
            //    Console.WriteLine("要切割文本行数");
            //    string num = Console.ReadLine();
            //    if (int.TryParse(num, out count))
            //    {
            //        break;
            //    }
            //}
            //切割文件.ToTxt(path, count);

            获取目录里面的文件.GetFiles(path);
        }
    }
}
