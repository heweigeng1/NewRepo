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
    
    public partial class AccountingHistoricalDatas
    {
        public System.Guid Id { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public int ItemDataType { get; set; }
        public string AreaCode { get; set; }
        public Nullable<decimal> AddedValueCurrentPrice1 { get; set; }
        public Nullable<decimal> AddedValueConstantPrice1 { get; set; }
        public Nullable<decimal> AddedValueCurrentPrice2 { get; set; }
        public Nullable<decimal> AddedValueConstantPrice2 { get; set; }
        public Nullable<decimal> AddedValueCurrentPrice3 { get; set; }
        public Nullable<decimal> AddedValueConstantPrice3 { get; set; }
        public Nullable<System.Guid> AreaQuarterStatisticId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual AreaQuarterStatistics AreaQuarterStatistics { get; set; }
    }
}
