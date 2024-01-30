using EmployeesProjects.ViewModels.ProjectVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.IServices
{
    public interface IProjectService
    {
        int Create(ProjectCreateVm vm);
        int Update(ProjectUpdateVm vm);
        int Delete(int projectId);
        List<ProjectListVm> GetAll();
        ProjectDetailVm Detail(int projectId);

    }
}
