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
    
    public partial class ItemLayerPermissionKindRls
    {
        public System.Guid Id { get; set; }
        public System.Guid PermisstionKindId { get; set; }
        public int LayerItemId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    
        public virtual LayerItems LayerItems { get; set; }
        public virtual PermissionKinds PermissionKinds { get; set; }
    }
}
