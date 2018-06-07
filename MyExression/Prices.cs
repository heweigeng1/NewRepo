namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prices
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public decimal Sales { get; set; }

        public int Discount { get; set; }

        public int Days { get; set; }
    }
}
