//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testEf.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkFlow
    {
        public System.Guid Id { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowCode { get; set; }
        public string WorkFlowOrder { get; set; }
        public Nullable<int> BusinessNumber { get; set; }
        public Nullable<int> IsLock { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> FormId { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}