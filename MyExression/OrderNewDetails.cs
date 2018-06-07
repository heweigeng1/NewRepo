namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderNewDetails
    {
        public Guid Id { get; set; }

        public Guid? OrderNewId { get; set; }

        public string SerialNum { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public string SerialLabel { get; set; }

        public int AutoRecord { get; set; }

        public int Resolution { get; set; }

        public int Index { get; set; }
    }
}
