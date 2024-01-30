using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.ViewModels.ProjectVms
{
    public class ProjectDetailVm
    {
        public string Name { get; set; }
        public string Description { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmloyeeNames { get; set; }
        public string EmployeeLasNames { get; set; }
    }
}
