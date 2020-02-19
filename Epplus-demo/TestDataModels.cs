using System;
using System.Collections.Generic;
using System.Text;

namespace Epplus_demo
{
    public class TestDataModels
    {
        public static List<Orders> GetData()
        {
            return new List<Orders>
            {
                new Orders
                {
                    Address="北京ABC",
                    Money=100,
                    Number="10001",
                    NickName="不是666",
                    Phone="13333333333",
                    UserName="hwg",
                    Details=new List<Goods>{ new Goods {
                        Count=2,
                        Money=10,
                        Name="大白菜"
                    } ,
                    new Goods
                    {
                        Count=4,
                        Money=2,
                        Name="萝卜"
                    }},
                },
                new Orders
                {
                    Address="天津666",
                    Money=60,
                    Number="10001",
                    NickName="不是666",
                    Phone="13333333333",
                    UserName="hwg",
                    Details=new List<Goods>{ new Goods {
                        Count=2,
                        Money=10,
                        Name="西红柿"
                    } ,
                    new Goods
                    {
                        Count=3,
                        Money=2,
                        Name="上海青"
                    }},
                }
            };
        }
    }

    public class Orders
    {
        public decimal Money { get; set; }
        public string Number { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Goods> Details { get; set; }
    }

    public class Goods
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int Count { get; set; }
    }
}
