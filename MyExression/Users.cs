namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            ArticleComments = new HashSet<ArticleComments>();
            Collects = new HashSet<Collects>();
            Comments = new HashSet<Comments>();
            Images = new HashSet<Images>();
            Orders = new HashSet<Orders>();
            PersonLabels = new HashSet<PersonLabels>();
            Projects = new HashSet<Projects>();
            Projects1 = new HashSet<Projects>();
            UserDistributorRLs = new HashSet<UserDistributorRLs>();
            UserRoleRLs = new HashSet<UserRoleRLs>();
        }

        public Guid Id { get; set; }

        [StringLength(250)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(200)]
        public string NickName { get; set; }

        public string PhoneNum { get; set; }

        [StringLength(250)]
        public string ImageKey { get; set; }

        public string Email { get; set; }

        public DateTime? Birthday { get; set; }

        public int UserType { get; set; }

        [StringLength(250)]
        public string Signature { get; set; }

        public int Gender { get; set; }

        [StringLength(20)]
        public string RegisterIp { get; set; }

        [StringLength(250)]
        public string RegisterAddress { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public Guid? AddressId { get; set; }

        public string OpenId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleComments> ArticleComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collects> Collects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Images> Images { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonLabels> PersonLabels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDistributorRLs> UserDistributorRLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleRLs> UserRoleRLs { get; set; }
    }
}
