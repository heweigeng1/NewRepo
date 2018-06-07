namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemInfoes
    {
        public Guid Id { get; set; }

        public Guid? UserId { get; set; }

        public int SysInfoType { get; set; }

        public string Content { get; set; }

        public int IsRead { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }
    }
}
