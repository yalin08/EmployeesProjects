using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.ViewModels.ProjectVms
{
    public class ProjectCreateVm
    {
        public string Name { get; set; }
        public string Description { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
