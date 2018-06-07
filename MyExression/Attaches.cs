namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attaches
    {
        public Guid Id { get; set; }

        public Guid FromId { get; set; }

        public int AttachType { get; set; }

        public string AttachUrl { get; set; }

        public string PersonLabel { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }
    }
}
