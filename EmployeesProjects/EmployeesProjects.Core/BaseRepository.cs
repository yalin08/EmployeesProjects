using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        DbContext _db;
        public BaseRepository(DbContext db)
        {
            _db = db;
        }

        public int Create(T entity)
        {
            _db.Add(entity);
            return _db.SaveChanges();
        }

        public int Delete(T entity)
        {
            _db.Remove(entity);
            return _db.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return (T)_db.Set<T>().FirstOrDefault(x => x.ID == id);
        }

        public int Update(T entity)
        {
            _db.Update(entity);
            return _db.SaveChanges();
        }
    }
}
