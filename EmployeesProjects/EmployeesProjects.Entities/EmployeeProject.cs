using EmployeesProjects.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Entities
{
    public class EmployeeProject:BaseEntity
    { 
        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        [ForeignKey("ProjectID")]
        public int ProjectID { get; set; }
        //public virtual ICollection<Employee> Employees { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }

       
        public Employee Employee { get; set; }


    }
}
