using EmployeesProjects.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Entities
{
    public class Project:BaseEntity
    {
        public Project()
        {
            EmployeeProject = new HashSet<EmployeeProject>();
        }

        public string Name { get; set; }
        public string Description { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public virtual ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
