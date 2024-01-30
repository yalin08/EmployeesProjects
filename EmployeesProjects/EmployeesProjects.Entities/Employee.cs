using EmployeesProjects.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Entities
{
    public class Employee:BaseEntity
    {

        public Employee()
        {
            EmployeeTask = new HashSet<EmployeeProject>();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string? Note { get; set; }

        public ICollection<EmployeeProject> EmployeeTask {  get; set; }
    }
}
