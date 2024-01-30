using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Dal.IRepositories;
using EmployeesProjects.Dal.Repositories;
using EmployeesProjects.Entities;
using EmployeesProjects.ViewModels.EmployeeProjectVms;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.Services
{
    public class EmployeeProjectService : IEmployeeProjectService
    {
        IEmployeeProjectRepository _employeeProjectRepo;
        public EmployeeProjectService()
        {
            _employeeProjectRepo = new EmployeeProjectRepository();
        }
        public int Create(EmployeeProjectCreateVm vm)
        {
            EmployeeProject ep = new EmployeeProject()
            {
                EmployeeID = vm.EmployeeID,
                ProjectID = vm.ProjectID,
            };
            return _employeeProjectRepo.Create(ep);

        }

        public int Delete(int employeeProjectId)
        {
            return _employeeProjectRepo.Delete(_employeeProjectRepo.GetByID(employeeProjectId));
        }

        public int Update(EmployeeProjectUpdateVm vm)
        {
            EmployeeProject ep = new EmployeeProject()
            {
                ID = vm.ID,
                EmployeeID = vm.EmployeeID,
                ProjectID = vm.ProjectID,
            };
            return _employeeProjectRepo.Update(ep);
        }


    }
}
