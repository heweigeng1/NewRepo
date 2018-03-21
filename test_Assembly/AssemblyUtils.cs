using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test_Assembly
{
    public static class AssemblyUtils
    {
        public static SortedDictionary<string, string> ObjToSortedDictionary(object obj)
        {
            SortedDictionary<string, string> map = new SortedDictionary<string, string>();
            Type type = obj.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                map.Add(item.Name, item.GetValue(obj).ToString());
            }
            return map;
        }
        public static string SortedDictionaryToString(this SortedDictionary<string, string> map)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in map)
            {
                sb.Append("&"+item.Key + "=" + item.Value);
            }
            sb.Remove(0, 1);//移除第一个&
            return sb.ToString();
        }
        public static string SortedDictionaryToXml(this SortedDictionary<string, string> map)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in map)
            {
                sb.Append($@"<{item.Key}>{item.Value}</{item.Key}>");
            }
            return $@"<xml>{sb.ToString()}</xml>";
        }
    }
}
