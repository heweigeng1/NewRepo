//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GdpTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasicGdpDatas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasicGdpDatas()
        {
            this.BasicGdpDataUserRLs = new HashSet<BasicGdpDataUserRLs>();
        }
    
        public System.Guid Id { get; set; }
        public string ReportName { get; set; }
        public int Status { get; set; }
        public int Delflag { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual Areas Areas { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicGdpDataUserRLs> BasicGdpDataUserRLs { get; set; }
    }
}
