using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Dal.Repositories;
using EmployeesProjects.Entities;
using EmployeesProjects.ViewModels.EmployeeVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.Services
{
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository _er;
        public EmployeeService()
        {
            _er = new EmployeeRepository();
        }
        public int Create(EmployeeCreateVm vm)
        {
            Employee employee = new Employee()
            {
                Name = vm.Name,
                LastName = vm.LastName,
                HireDate = vm.HireDate,
                Note = vm.Note
            };
            return _er.Create(employee);
        }

        public int Delete(int employeeID)
        {
            Employee employee = _er.GetByID(employeeID);

            return _er.Delete(employee);
        }

        public EmployeeDetailVm Detail(int employeeId)
        {
            Employee e = _er.GetByID(employeeId);
            EmployeeDetailVm vm = new EmployeeDetailVm()
            {
                ID = e.ID,
                    Name = e.Name,
                     LastName= e.LastName,
                HireDate = e.HireDate,
                Note = e.Note,  
              //  ProjectNames = e
            };
            return vm;
        }

        public List<EmployeeListVm> GetAll()
        {
            List<EmployeeListVm> elvmList = new List<EmployeeListVm>();

            foreach (Employee e in _er.GetAll())
            {
                EmployeeListVm elvm = new EmployeeListVm()
                {
                    ID = e.ID,
                    Name = e.Name,
                    HireDate = e.HireDate,
                    LastName = e.LastName
                };
                elvmList.Add(elvm);
            }

            return elvmList;

        }

        public int Update(EmployeeUpdateVm vm)
        {
            Employee updatedVm = new Employee()
            {
                ID=vm.ID,
                Name=vm.Name,
                LastName=vm.LastName,
                Note=vm.Note,
            };

            return _er.Update(updatedVm);
        }
    }
}
