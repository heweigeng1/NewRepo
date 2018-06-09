using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LYLibrary.FileOperate
{
    /// <summary>
    /// 包含对文件的操作,包括移动,剪切删除,分割
    /// </summary>
    public static class 移动
    {
        /// <summary>
        /// 移动文件到当前软件的当前目录指定文件夹下
        /// </summary>
        /// <param name="fileName">目标文件</param>
        /// <param name="folder">文件夹</param>
        public static void MoveTo(string fileName, string folder)
        {
            string name = Path.GetFileName(fileName);
            string path = Directory.GetCurrentDirectory() + "/"+ folder;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.Move(fileName, path + name);
        }
    }
}
