//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MS.MatrixOA.Express.Business
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        public UserGroup()
        {
            this.UserGroupPermission = new HashSet<UserGroupPermission>();
        }
    
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    
        public virtual ICollection<UserGroupPermission> UserGroupPermission { get; set; }
    }
}