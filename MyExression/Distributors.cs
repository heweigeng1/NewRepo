namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Distributors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distributors()
        {
            Areas = new HashSet<Areas>();
            Orders = new HashSet<Orders>();
        }

        public Guid Id { get; set; }

        [StringLength(200)]
        public string DistributorName { get; set; }

        [StringLength(500)]
        public string DistributorAddress { get; set; }

        [StringLength(20)]
        public string PhoneNum { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }

        public DateTime? LastOrderTime { get; set; }

        public int Status { get; set; }

        public Guid? AreaId { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Areas> Areas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
