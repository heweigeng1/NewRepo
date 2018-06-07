using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNodify
{
    public static class SaveFile
    {
        public static string ToTxt(string data, string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            string path = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                var chars = data.ToCharArray();
                //从指定的位置开始写入
                fs.Position = fs.Length;
                sw.WriteLine(data);
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
