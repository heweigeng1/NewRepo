//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoMapperTest.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasicGdpDataItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasicGdpDataItems()
        {
            this.BasicGdpDataItemRecords = new HashSet<BasicGdpDataItemRecords>();
        }
    
        public System.Guid Id { get; set; }
        public string ItemName { get; set; }
        public int Type { get; set; }
        public int Delflag { get; set; }
        public int Unit { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicGdpDataItemRecords> BasicGdpDataItemRecords { get; set; }
    }
}
