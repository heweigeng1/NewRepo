namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Koriyasus
    {
        public Guid Id { get; set; }

        public Guid? ProjectId { get; set; }

        public string Name { get; set; }

        public string ServiceTime { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public virtual Projects Projects { get; set; }
    }
}
