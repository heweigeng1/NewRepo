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
    
    public partial class Document
    {
        public System.Guid Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string DocNumber { get; set; }
        public string SecretLevel { get; set; }
        public string EmergencyLevel { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserDepartment { get; set; }
        public string Attachment { get; set; }
        public string AttachmentPath { get; set; }
        public string Context { get; set; }
        public string Reader { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string ReaderData { get; set; }
    }
}
