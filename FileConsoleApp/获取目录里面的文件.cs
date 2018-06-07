using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsoleApp
{
    public static class 获取目录里面的文件
    {
        public static void GetFiles(string path)
        {
            var dir = Directory.GetFiles(path).ToList();
        }
    }
}
