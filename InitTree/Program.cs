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
            for (int i = 1; i < 200; i++)
            {
                num++;
                list.Add(new TreeEntity
                {
                    Id = num,
                    Pid = new Random().Next(0, 10),
                    Name = "name" + num,
                });
            }
            for (int i = 1; i < 200; i++)
            {
                num++;
                list.Add(new TreeEntity
                {
                    Id = num,
                    Pid = new Random().Next(10, 20),
                    Name = "name" + num,
                });
            }
            for (int i = 1; i < 200; i++)
            {
                num++;
                list.Add(new TreeEntity
                {
                    Id = num,
                    Pid = new Random().Next(20, 30),
                    Name = "name" + num,
                });
            }
            for (int i = 1; i < 200; i++)
            {
                num++;
                list.Add(new TreeEntity
                {
                    Id = num,
                    Pid = new Random().Next(30, 40),
                    Name = "name" + num,
                });
            }
            return list;
        }
    }
}
