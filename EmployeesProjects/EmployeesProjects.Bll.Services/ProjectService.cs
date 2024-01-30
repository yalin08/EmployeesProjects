using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Dal.IRepositories;
using EmployeesProjects.Dal.Repositories;
using EmployeesProjects.Entities;
using EmployeesProjects.ViewModels.ProjectVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProjects.Bll.Services
{
    public class ProjectService : IProjectService
    {
        IProjectRepository _projectRepo;

        public ProjectService()
        {
            _projectRepo = new ProjectRepository();
        }
        public int Create(ProjectCreateVm vm)
        {
            Project project = new Project()
            {
                Name = vm.Name,
                Description = vm.Description,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };
            return _projectRepo.Create(project);
        }

        public int Delete(int projectId)
        {
            return _projectRepo.Delete(_projectRepo.GetByID(projectId));
        }

        public ProjectDetailVm Detail(int projectId)
        {
            Project project = _projectRepo.GetByID(projectId);
            ProjectDetailVm projectDetailVm = new ProjectDetailVm()
            {
                Name=project.Name,
                Description=project.Description,
                StartDate=project.StartDate,
                EndDate=project.EndDate,
            };
            return projectDetailVm;
        }

        public List<ProjectListVm> GetAll()
        {
            //List<ProjectListVm>  projectListVms = new List<ProjectListVm>();
            //foreach (Project project in _projectRepo.GetAll())
            //{
            //    ProjectListVm p = new ProjectListVm()
            //    {
            //        Name = project.Name,
            //        Description = project.Description,
            //        StartDate = project.StartDate,
            //        EndDate = project.EndDate
            //    };
            //    projectListVms.Add(p);
            //}
            //return projectListVms;

            List<ProjectListVm> projectListVms = _projectRepo.GetAll().Select(x => new ProjectListVm
            {
                Name = x.Name,
                Description = x.Description,
                StartDate=x.StartDate,
                EndDate=x.EndDate
            }).ToList(); return projectListVms;
        }

        public int Update(ProjectUpdateVm vm)
        {
            Project project = new Project()
            {
                ID = vm.Id,
                Name = vm.Name,
                Description = vm.Description,
                EndDate = vm.EndDate
            };

            return _projectRepo.Update(project);
        }


    }
}
