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
    
    public partial class User
    {
        public User()
        {
            this.UserPermission = new HashSet<UserPermission>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Audit { get; set; }
        public Nullable<int> GroupId { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual ICollection<UserPermission> UserPermission { get; set; }
    }
}
