using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class UserGroupPermissionService:BaseRepository<UserGroupPermission>
    {
        public UserGroupPermission FindBy(int groupId,string permission)
        {
            return db.UserGroupPermission.SingleOrDefault(v => v.GroupId == groupId && v.Permission == permission);
        }
    }
}
