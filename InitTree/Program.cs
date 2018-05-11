using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
namespace InitTree
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TreeEntity> list = InitArray();
            TreeEntity entity = new TreeEntity { Name = "root" };
            Add(entity, list);

            Console.WriteLine(JsonConvert.SerializeObject(entity));

            Console.ReadLine();
        }
        private static void Add(TreeEntity entity, List<TreeEntity> list)
        {
            try
            {
                var child = list.Where(c => c.Pid == entity.Id).ToList();
                if (child.Count > 0)
                {
                    entity.Child.AddRange(child);
                    foreach (var item in child)
                    {
                        Add(item, list);
                    }
                }
            }
            catch (Exception)
            {
            }

        }
        private static List<TreeEntity> InitArray()
        {
            List<TreeEntity> list = new List<TreeEntity>();
            int num = 0;
            for (int y = 1; y < 4; y++)
            {
                for (int i = 1; i < 200; i++)
                {
                    num++;
                    list.Add(new TreeEntity
                    {
                        Id = num,
                        Pid = new Random().Next((y-1)*10, y*10),
                        Name = "name" + num,
                    });
                }
            }
            return list;
        }
    }
}
