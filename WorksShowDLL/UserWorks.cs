//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorksShowDll
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserWorks
    {
        public long UserWorksID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> WorksID { get; set; }
        public Nullable<int> Relationship { get; set; }
        public Nullable<int> Flag { get; set; }
    
        public virtual User User { get; set; }
        public virtual Works Works { get; set; }
    }
}
