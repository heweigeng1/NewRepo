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
    
    public partial class WorkFlowInstanceProcessIdea
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> WorkFlowInstanceId { get; set; }
        public Nullable<System.Guid> WorkFlowInstanceProcessId { get; set; }
        public Nullable<System.Guid> AppAdminId { get; set; }
        public Nullable<int> AppResult { get; set; }
        public string AppIdea { get; set; }
        public string AppIP { get; set; }
        public Nullable<System.DateTime> AppTime { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
