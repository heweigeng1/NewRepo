namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderNews
    {
        public Guid Id { get; set; }

        public string OrderNum { get; set; }

        public Guid? Uid { get; set; }

        public string ProductName { get; set; }

        public string NameDes { get; set; }

        public string Thumb { get; set; }

        public int Amount { get; set; }

        public decimal Total { get; set; }

        public int PayType { get; set; }

        public int OrderStatus { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public Guid? Pid { get; set; }

        public int Days { get; set; }
    }
}
