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
    
    public partial class SmallScaleIndustryRecords
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SmallScaleIndustryRecords()
        {
            this.Enterprises = new HashSet<Enterprises>();
        }
    
        public System.Guid Id { get; set; }
        public string SmallScaleIndustryName { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> SelfEmployedCount { get; set; }
        public Nullable<int> SelfEmployedCorrespondingPeriodCount { get; set; }
        public Nullable<int> SmallBusinessCount { get; set; }
        public Nullable<int> SmallBusinessCorrespondingPeriodCount { get; set; }
        public Nullable<decimal> SmallBusinessAmount { get; set; }
        public Nullable<decimal> SmallBusinessCorrespondingPeriodAmount { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> CorrespondingPeriodCount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> CorrespondingPeriodAmount { get; set; }
        public int SubmitStatus { get; set; }
        public int Delflag { get; set; }
        public int ApplyDelay { get; set; }
        public int DelayStatus { get; set; }
        public string ResponsibleForUser { get; set; }
        public System.Guid AreaQuarterStatisticId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual AreaQuarterStatistics AreaQuarterStatistics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enterprises> Enterprises { get; set; }
    }
}
