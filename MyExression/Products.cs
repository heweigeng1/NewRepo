namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string NameDes { get; set; }

        public string Type { get; set; }

        public string PicUrl { get; set; }

        public string Thumb { get; set; }

        public string Tip1 { get; set; }

        public string Tipdes1 { get; set; }

        public string Tip2 { get; set; }

        public string Tipdes2 { get; set; }

        public string Tip3 { get; set; }

        public string Tipdes3 { get; set; }

        public decimal Price { get; set; }

        public decimal Sales { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public string PicServiceUrl { get; set; }
    }
}
