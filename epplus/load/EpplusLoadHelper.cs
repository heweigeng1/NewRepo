using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace epplus.load
{
    public static class EpplusLoadHelper
    {
        /// <summary>
        /// 泛型方式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static IEnumerable<T> LoadFromExcel<T>(string FileName) where T : new()
        {
            FileInfo existingFile = new FileInfo(FileName);
            List<T> resultList = new List<T>();
            Dictionary<string, int> dictHeader = new Dictionary<string, int>();

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int colStart = worksheet.Dimension.Start.Column;  //工作区开始列
                int colEnd = worksheet.Dimension.End.Column;       //工作区结束列
                int rowStart = worksheet.Dimension.Start.Row+1 ;       //工作区开始行号
                int rowEnd = worksheet.Dimension.End.Row;       //工作区结束行号

                //将每列标题添加到字典中
                for (int i = colStart; i <= colEnd; i++)
                {
                    dictHeader[worksheet.Cells[rowStart, i].Value.ToString()] = i;
                }

                List<PropertyInfo> propertyInfoList = new List<PropertyInfo>(typeof(T).GetProperties());

                for (int row = rowStart+1; row <= rowEnd; row++)
                {
                    T result = new T();

                    //为对象T的各属性赋值
                    foreach (PropertyInfo p in propertyInfoList)
                    {
                        try
                        {
                            ExcelRange cell = worksheet.Cells[row, dictHeader[p.Name]]; //与属性名对应的单元格

                            if (cell.Value == null)
                                continue;
                            switch (p.PropertyType.Name.ToLower())
                            {
                                case "guid":
                                    p.SetValue(result, new Guid(cell.Text));
                                    break;
                                case "string":
                                    p.SetValue(result, cell.GetValue<String>());
                                    break;
                                case "int16":
                                    p.SetValue(result, cell.GetValue<Int16>());
                                    break;
                                case "int32":
                                    p.SetValue(result, cell.GetValue<Int32>());
                                    break;
                                case "int64":
                                    p.SetValue(result, cell.GetValue<Int64>());
                                    break;
                                case "decimal":
                                    p.SetValue(result, cell.GetValue<Decimal>());
                                    break;
                                case "double":
                                    p.SetValue(result, cell.GetValue<Double>());
                                    break;
                                case "datetime":
                                    p.SetValue(result, cell.GetValue<DateTime>());
                                    break;
                                case "boolean":
                                    p.SetValue(result, cell.GetValue<Boolean>());
                                    break;
                                case "byte":
                                    p.SetValue(result, cell.GetValue<Byte>());
                                    break;
                                case "char":
                                    p.SetValue(result, cell.GetValue<Char>());
                                    break;
                                case "single":
                                    p.SetValue(result, cell.GetValue<Single>());
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (KeyNotFoundException ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    resultList.Add(result);
                }
            }
            return resultList;
        }
    }
}
