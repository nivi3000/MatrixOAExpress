using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class UserService:BaseRepository<User>
    {

        public bool CheckPwd(string userName,string password)
        {
            return db.User.SingleOrDefault(v => v.UserName == userName && v.Password == password) != null;
        }

        public bool CheckUserNameForRegist(string userName)
        {
            return db.User.SingleOrDefault(v => v.UserName == userName) == null;
        }

        public void Add(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }

        public void ChangePwd(int userId,string newPwd)
        {
            db.User.Single(v => v.UserId == userId).Password = newPwd;
            db.SaveChanges();
        }

        public User GetUserByUserName(string userName)
        {
            return db.User.Single(v => v.UserName == userName);
        }

        public User FindBy(int id)
        {
            return db.User.Single(v => v.UserId == id);
        }

        public List<User> FindAll()
        {
            return db.User.ToList();
        }

        public IQueryable<User> FindAll(int pageIndex,int pageSize)
        {
            return db.User.Skip(pageSize * (pageIndex - 1)).Take(pageSize).AsQueryable();
        }
    }
}
