using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ScanApp.DAL.DBContext;

namespace VisionNet472.DAL.Repositories
{
    public class Repository<T> :IRepository<T> where T:class ,new()
    {
        private readonly SqlSugarClient _db;

        public Repository()
        {
            _db = MyDbContext.Instance;
        }

        public T GetById(object id)
        {
            return _db.Queryable<T>().InSingle(id);
        }

        public List<T> GetAll()
        {
            return _db.Queryable<T>().ToList();
        }

        public List<T> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return _db.Queryable<T>().Where(predicate).ToList();
        }

        public void Insert(T entity)
        {
            _db.Insertable(entity).ExecuteCommand();
        }

        public void Update(T entity)
        {
            _db.Updateable(entity).ExecuteCommand();
        }

        public void Delete(object id)
        {
            _db.Deleteable<T>().In(id).ExecuteCommand();
        }

        public void DeleteByCondition(Expression<Func<T, bool>> predicate)
        {
            _db.Deleteable<T>().Where(predicate).ExecuteCommand();
        }
    }
}
