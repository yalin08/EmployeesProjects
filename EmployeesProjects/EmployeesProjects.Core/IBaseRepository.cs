using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Core
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);
        ICollection<T> GetAll();
        T GetByID(int id);
    }
}
