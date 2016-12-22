//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace epplus.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estates()
        {
            this.EstateDatas = new HashSet<EstateDatas>();
        }
    
        public System.Guid Id { get; set; }
        public decimal SalesFloorSpace { get; set; }
        public decimal SalesFloorSpaceCorrespondingPeriod { get; set; }
        public decimal Amount { get; set; }
        public decimal CorrespondingPeriodAmount { get; set; }
        public System.Guid AreaQuarterStatisticId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual AreaQuarterStatistics AreaQuarterStatistics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstateDatas> EstateDatas { get; set; }
    }
}
