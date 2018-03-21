using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsoleApp
{
    public static class SaveFile
    {
        public static string SaveToTxt(string data, string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            string path = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(data);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                return fileName = "error";
            }
            return fileName;
        }
    }
}
