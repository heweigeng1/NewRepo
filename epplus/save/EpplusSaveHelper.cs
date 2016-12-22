using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.IO;

namespace epplus.save
{
    public class EpplusSaveHelper
    {
        public static void SaveToExcel<T>(IEnumerable<T> data, string FileName, string OpenPassword = "")
        {
            FileInfo file = new FileInfo(FileName);
            try
            {
                using (ExcelPackage ep = new ExcelPackage(file, OpenPassword))
                {
                    ExcelWorksheet ws = ep.Workbook.Worksheets.Add(typeof(T).Name);
                    ws.Cells["A1"].LoadFromCollection(data, true, TableStyles.Medium10);

                    ep.Save(OpenPassword);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SaveToExcel<T>(IEnumerable<T> data, string fileName,string[] titel)
        {
            FileInfo file = new FileInfo(fileName);
            string path = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                using (ExcelPackage ep = new ExcelPackage(file))//创建
                {
                    ExcelWorksheet ws = ep.Workbook.Worksheets[typeof(T).Name];
                    if (ws == null)
                    {
                        ws = ep.Workbook.Worksheets.Add(typeof(T).Name);//添加sheet
                    }
                    
                    for (int i = 0; i < titel.Length; i++)
                    {
                        ws.Cells[1, i+1].Value = titel[i];
                    }
                    ws.Cells["A2"].LoadFromCollection(data, true, TableStyles.Medium10);
                    ep.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
