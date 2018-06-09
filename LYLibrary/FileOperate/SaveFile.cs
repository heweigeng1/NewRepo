using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LYLibrary.FileOperate
{
    /// <summary>
    /// 保存文件
    /// </summary>
    public static class SaveFile
    {
        /// <summary>
        /// 保存数据到txt,并且换行. FileMode.OpenOrCreate，
        /// 可以简单模拟写日志。
        /// </summary>
        /// <param name="data">要保存的数据</param>
        /// <param name="fileName">文件名称</param>
        /// <returns></returns>
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
