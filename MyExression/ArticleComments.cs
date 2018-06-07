namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArticleComments
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ArticleId { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public Guid? PId { get; set; }

        public string Content { get; set; }

        public int ReadState { get; set; }

        public virtual Articles Articles { get; set; }

        public virtual Users Users { get; set; }
    }
}
