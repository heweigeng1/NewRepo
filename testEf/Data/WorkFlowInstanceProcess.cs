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
    
    public partial class WorkFlowInstanceProcess
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ProcessFatherId { get; set; }
        public Nullable<System.Guid> WorkFlowId { get; set; }
        public Nullable<System.Guid> WorkFlowStepId { get; set; }
        public Nullable<System.Guid> WorkFlowInstanceId { get; set; }
        public Nullable<System.Guid> AppRoleId { get; set; }
        public Nullable<System.Guid> SubAdminId { get; set; }
        public Nullable<System.DateTime> SubmitTime { get; set; }
        public Nullable<int> IsAlreadyApp { get; set; }
        public Nullable<System.Guid> AppAdminId { get; set; }
        public Nullable<int> AppAreaNumber { get; set; }
        public Nullable<int> AppResult { get; set; }
        public Nullable<System.DateTime> AppTime { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}