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
    
    public partial class WorkFlowStep
    {
        public System.Guid Id { get; set; }
        public string StepName { get; set; }
        public string OprationKind { get; set; }
        public Nullable<System.Guid> StepFatherId { get; set; }
        public Nullable<System.Guid> WorkFlowId { get; set; }
        public string AppRoleCode { get; set; }
        public Nullable<int> StepOrder { get; set; }
        public string Description { get; set; }
        public Nullable<int> WorkFlowType { get; set; }
        public Nullable<int> IsAppEnd { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
