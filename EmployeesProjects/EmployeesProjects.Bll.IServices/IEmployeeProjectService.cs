using EmployeesProjects.ViewModels.EmployeeProjectVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.IServices
{
    public interface IEmployeeProjectService 
    {

        int Create(EmployeeProjectCreateVm vm);
        int Update(EmployeeProjectUpdateVm vm);
        int Delete(int employeeProjectId);
    }
}
