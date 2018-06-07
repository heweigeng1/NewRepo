namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courses()
        {
            Comments = new HashSet<Comments>();
        }

        public Guid Id { get; set; }

        public Guid? PId { get; set; }

        public int CourseType { get; set; }

        public string CourseLabel { get; set; }

        public string Describe { get; set; }

        public int CoursePro { get; set; }

        public int IsRead { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public Guid? ProjectId { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        public virtual Projects Projects { get; set; }
    }
}
