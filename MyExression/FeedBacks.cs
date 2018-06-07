namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FeedBacks
    {
        public Guid Id { get; set; }

        public Guid? UserId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }
    }
}
