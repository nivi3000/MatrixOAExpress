using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class DepartmentService
    {
        private DbContext db = new DbContext();
        private int treeLevel = 0;

        public void Create(Department department)
        {
            db.Department.Add(department);
            db.SaveChanges();
        }

        public List<DepartmentViewModel> GetAll()
        {
            List<DepartmentViewModel> result = new List<DepartmentViewModel>();
            foreach (Department topDepartment in db.Department.Where(v => v.ParentId == 0).OrderBy(v => v.SortCode))
            {
                treeLevel = 0;
                addDepartmentViewModel(result, topDepartment);
                addSubDepartment(result, topDepartment);
            }
            return result;
        }

        public Department GetBy(int departmentId)
        {
            return db.Department.Single(v => v.DepartmentId == departmentId);
        }

        public int GetSortCode(int parentDepartmentId)
        {
            try 
            { 
                return db.Department.Where(v => v.ParentId == parentDepartmentId).Select(v => v.SortCode).Max() + 1; 
            }
            catch
            {
                return 1;
            }

        }

        private void addDepartmentViewModel(List<DepartmentViewModel> result, Department department)
        {
            User user = db.User.SingleOrDefault(v => v.UserId == department.LeaderId);
            result.Add(new DepartmentViewModel
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName,
                Description = department.Description,
                LeaderName = user != null ? user.UserInfo.RealName : string.Empty,
                TreeLevel = treeLevel
            });
        }

        private void addSubDepartment(List<DepartmentViewModel> result, Department topDepartment)
        {
            treeLevel++;
            foreach (Department department in getSubDepartment(topDepartment))
            {
                addDepartmentViewModel(result, department);
                addSubDepartment(result, department);
            }
            treeLevel--;
        }

        public IEnumerable<Department> getSubDepartment(Department topDepartment)
        {
            return db.Department.Where(v => v.ParentId == topDepartment.DepartmentId).OrderBy(v => v.SortCode);
        }

        public IEnumerable<Department> getSubDepartment(int parentId)
        {
            return db.Department.Where(v => v.ParentId == parentId).OrderBy(v => v.SortCode);
        }

        public void UpSort(int id)
        {
            Department current = GetBy(id);
            if(current.SortCode>1)
            {
                Department previous = db.Department.Single(v => v.SortCode == current.SortCode - 1&&v.ParentId==current.ParentId);
                previous.SortCode++;
                current.SortCode--;
                db.SaveChanges();
            }
        }

        public void DownSort(int id)
        {
            Department current = GetBy(id);
            if (current.SortCode != GetSortCode(current.ParentId)-1)
            {
                Department next = db.Department.Single(v => v.SortCode == current.SortCode + 1 && v.ParentId == current.ParentId);
                next.SortCode--;
                current.SortCode++;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Department department = GetBy(id);
            db.Department.Remove(department);
            foreach(Department temp in db.Department.Where(v=>v.ParentId==department.ParentId&&v.SortCode>department.SortCode))
            {
                temp.SortCode--;
            }
            db.SaveChanges();
        }

        public bool HasSubDepartment(int id)
        {
            return db.Department.Any(v => v.ParentId == id);
        }

        public void Update(Department department)
        {
            Department departmentForUpdate = db.Department.Single(v => v.DepartmentId == department.DepartmentId);
            departmentForUpdate.DepartmentName = department.DepartmentName;
            departmentForUpdate.Description = department.Description;
            departmentForUpdate.LeaderId = department.LeaderId;
            departmentForUpdate.ParentId = department.ParentId;
            departmentForUpdate.SortCode = department.SortCode;
            db.SaveChanges();
        }
    }

    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string LeaderName { get; set; }
        public int TreeLevel { get; set; }
    }
}
