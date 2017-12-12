using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class PermissionService:BaseRepository<Permission>
    {

        public Permission FindBy(int id)
        {
            return db.Permission.Single(v => v.PermissionId == id);
        }
    }
}
