using System;
using System.Collections.Generic;
using System.Text;

namespace InitTree
{
   public class TreeEntity
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; }
        public ICollection<TreeEntity> Child { get; set; } 
    }
}
