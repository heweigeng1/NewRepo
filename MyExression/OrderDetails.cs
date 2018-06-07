namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid CommodityId { get; set; }

        public int Count { get; set; }

        public decimal? CDPrice { get; set; }

        [StringLength(200)]
        public string CDName { get; set; }

        [StringLength(500)]
        public string CDPicUrl { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public virtual Commodities Commodities { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
