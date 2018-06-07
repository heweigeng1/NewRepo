using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsoleApp
{
    public static class 切割文件
    {
        public static void ToTxt(string basePath, int count)
        {
            var lines = File.ReadAllLines(basePath);
            int txtcount = lines.Length / count;
            
            for (int i = 0; i < txtcount; i++)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + $"/qiege/"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + $"/qiege/");
                }
              File.CreateText(Directory.GetCurrentDirectory() + $"/qiege/{i}.txt").Close();
                File.WriteAllLines(Directory.GetCurrentDirectory() + $"/qiege/{i}.txt", lines.Skip(i * count).Take(count));
            }
        }
    }
}
