using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.MatrixOA.Express.Business
{
    public class BaseRepository<T> where T : class
    {
        protected DbContext db = new DbContext();

        public T Create(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Added;
            db.SaveChanges();
            return entity;
        }

        public bool Update(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry<T>(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry<T>(entity).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public IQueryable<T> FindAll()
        {
            return db.Set<T>().AsQueryable();
        }

        public IQueryable<T> FindAll(Func<T, bool> wherelambda)
        {
            return db.Set<T>().Where<T>(wherelambda).AsQueryable();
        }

        public IQueryable<T> FindAll<S>(int pageSize, int pageIndex, out int recordCount, bool isAsc, Func<T, S> orderByLambda)
        {
            var tempData = db.Set<T>().AsQueryable();

            recordCount = tempData.Count();

            //排序获取当前页的数据
            if (isAsc)
            {
                tempData = tempData.OrderBy<T, S>(orderByLambda).
                Skip<T>(pageSize * pageIndex).
                Take<T>(pageSize).AsQueryable();
            }
            else
            {
                tempData = tempData.OrderByDescending<T, S>(orderByLambda).
                Skip<T>(pageSize * pageIndex).
                Take<T>(pageSize).AsQueryable();
            }
            return tempData;
        }

        //分页 keleyi.com
        public IQueryable<T> FindAll<S>(int pageSize, int pageIndex, out int total,
        Func<T, bool> whereLambda, bool isAsc, Func<T, S> orderByLambda)
        {
            var tempData = db.Set<T>().Where<T>(whereLambda);

            total = tempData.Count();

            //排序获取当前页的数据
            if (isAsc)
            {
                tempData = tempData.OrderBy<T, S>(orderByLambda).
                Skip<T>(pageSize * pageIndex).
                Take<T>(pageSize).AsQueryable();
            }
            else
            {
                tempData = tempData.OrderByDescending<T, S>(orderByLambda).
                Skip<T>(pageSize * pageIndex).
                Take<T>(pageSize).AsQueryable();
            }
            return tempData.AsQueryable();
        }
    }
}
