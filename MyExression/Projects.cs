namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects()
        {
            Courses = new HashSet<Courses>();
            Koriyasus = new HashSet<Koriyasus>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Area { get; set; }

        public string HouseStyle { get; set; }

        public string ProjectNum { get; set; }

        public string PicUrl { get; set; }

        public string OwnerPicUrl { get; set; }

        public int ProjectPro { get; set; }

        public int FocusNum { get; set; }

        public int Quality { get; set; }

        public int Attitude { get; set; }

        public DateTime? CommentTime { get; set; }

        public string CommentContent { get; set; }

        public int Koriyasu { get; set; }

        public Guid? OwnerUserId { get; set; }

        public Guid ForemanUserId { get; set; }

        public int RoomNum { get; set; }

        public int HallNum { get; set; }

        public int KitchenNum { get; set; }

        public int ToiletNum { get; set; }

        public string OwnerName { get; set; }

        public string OwnerPhone { get; set; }

        public string OwnerRequire { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Address { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public DateTime? CommentTimeAg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koriyasus> Koriyasus { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
