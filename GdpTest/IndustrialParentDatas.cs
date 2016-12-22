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
    
    public partial class IndustrialParentDatas
    {
        public System.Guid Id { get; set; }
        public Nullable<decimal> IndividualOutputValue { get; set; }
        public Nullable<decimal> IndividualCorrespondingPeriodOutputValue { get; set; }
        public Nullable<decimal> IndustrialOutputValue { get; set; }
        public Nullable<decimal> IndustrialCorrespondingPeriodOutputValue { get; set; }
        public Nullable<int> LargeIndustrialProportion { get; set; }
        public Nullable<int> SmallScaleIndustryProportion { get; set; }
        public Nullable<decimal> IndustrialIncrements { get; set; }
        public Nullable<decimal> IncrementsRate { get; set; }
        public Nullable<decimal> LargeIndustrialIncrementRate { get; set; }
        public Nullable<decimal> SmallScaleIndustryIncrementRate { get; set; }
        public Nullable<decimal> MaxEfficacyCoefficient { get; set; }
        public Nullable<decimal> MinEfficacyCoefficient { get; set; }
        public Nullable<System.Guid> QuarterStatisticId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual QuarterStatistics QuarterStatistics { get; set; }
    }
}
