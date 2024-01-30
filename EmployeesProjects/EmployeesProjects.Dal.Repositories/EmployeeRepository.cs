using EmployeesProjects.Core;
using EmployeesProjects.Dal.IRepositories;
using EmployeesProjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Dal.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext db = null) : base(db ?? new EmployeesProjectsDbContext())
        {
        }
    }
}
