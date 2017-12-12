using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class UserGroupService:BaseRepository<UserGroup>
    {
        public UserGroup FindBy(int id)
        {
            return db.UserGroup.Single(v => v.GroupId == id);
        }
    }
}
