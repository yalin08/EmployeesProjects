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
    public class EmployeeProjectRepository : BaseRepository<EmployeeProject>, IEmployeeProjectRepository
    {
        public EmployeeProjectRepository(DbContext db=null) : base(db ?? new EmployeesProjectsDbContext())
        {
        }
    }
}
