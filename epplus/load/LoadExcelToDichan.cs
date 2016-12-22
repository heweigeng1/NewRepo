using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epplus.load
{
    public static class LoadExcelToDichan
    {
        public static void ExcelToObject(string filename)
        {
            FileInfo info = new FileInfo(filename);
            using (ExcelPackage ep=new ExcelPackage(info))
            {

            }
        }
    }
}
