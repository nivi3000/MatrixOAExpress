using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class UserInfoService:BaseRepository<UserInfo>
    {

        public UserInfo FindBy(int userId)
        {
            return db.UserInfo.Single(v => v.UserId == userId);
        }

        public void Update(UserInfo userInfo)
        {
            UserInfo userInfoForUpdate = FindBy(userInfo.UserId);
            userInfoForUpdate.RealName = userInfo.RealName;
            userInfoForUpdate.Address = userInfo.Address;
            userInfoForUpdate.Phone = userInfo.Phone;
            userInfoForUpdate.OfficePhone = userInfo.OfficePhone;
            userInfoForUpdate.HomePhone = userInfo.HomePhone;
            userInfoForUpdate.Fax = userInfo.Fax;
            userInfoForUpdate.Email = userInfo.Email;
            userInfoForUpdate.DepartmentId = userInfo.DepartmentId;
            userInfoForUpdate.Post = userInfo.Post;
            userInfoForUpdate.Picture = userInfo.Picture;
            db.SaveChanges();
        }
    }
}
