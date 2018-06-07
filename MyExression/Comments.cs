namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        public Guid Id { get; set; }

        public Guid? PId { get; set; }

        public string Content { get; set; }

        public Guid? CourseId { get; set; }

        public Guid? UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public virtual Courses Courses { get; set; }

        public virtual Users Users { get; set; }
    }
}
