using EmployeesProjects.ViewModels.EmployeeVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.IServices
{
    public interface IEmployeeService
    {
        int Create(EmployeeCreateVm vm);
        int Update(EmployeeUpdateVm vm);
        int Delete(int employeeID);
        List<EmployeeListVm> GetAll();
        EmployeeDetailVm Detail(int employeeId);
    }
}
