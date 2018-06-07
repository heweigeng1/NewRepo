namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articles()
        {
            ArticleComments = new HashSet<ArticleComments>();
            Collects = new HashSet<Collects>();
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Img { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public int Status { get; set; }

        public DateTime? ReleaseTime { get; set; }

        public int Views { get; set; }

        public int Share { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleComments> ArticleComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collects> Collects { get; set; }
    }
}
