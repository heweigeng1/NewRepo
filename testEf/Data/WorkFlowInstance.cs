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
    
    public partial class WorkFlowInstance
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> WorkFlowId { get; set; }
        public Nullable<System.Guid> WorkFlowStepId { get; set; }
        public Nullable<System.Guid> StartAdminId { get; set; }
        public Nullable<int> StartAreaNumber { get; set; }
        public string OrgName { get; set; }
        public Nullable<int> CurrentAreaNumber { get; set; }
        public Nullable<int> BusinessNumber { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public string Title { get; set; }
        public Nullable<System.Guid> BusinessId { get; set; }
        public Nullable<System.Guid> AppRoleId { get; set; }
        public Nullable<int> AppState { get; set; }
        public Nullable<System.DateTime> AppBeginTime { get; set; }
        public Nullable<System.DateTime> AppEndTime { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    }
}
