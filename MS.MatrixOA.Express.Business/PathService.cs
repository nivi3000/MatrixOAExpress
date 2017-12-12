using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class PathService:BaseRepository<Path>
    {
        public Path FindBy(int id)
        {
            return db.Path.Single(v => v.PathId == id);
        }
    }
}
