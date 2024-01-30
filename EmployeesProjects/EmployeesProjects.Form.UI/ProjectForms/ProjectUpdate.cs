using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Bll.Services;
using EmployeesProjects.ViewModels.ProjectVms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesProjects.Forms.UI.ProjectForms
{
    public partial class ProjectUpdate : Form
    {
        IProjectService _projectservice;
        int ID;
        ProjectList _project;

        public ProjectUpdate(ViewModels.ProjectVms.ProjectUpdateVm projectUpdateVm, ProjectList project)
        {
            InitializeComponent();
            _projectservice = new ProjectService();
            Update(projectUpdateVm);
            ID = projectUpdateVm.Id;
            _project = project;
        }

        
        public void Update(ProjectUpdateVm projectUpdateVm)
        {
            txtName.Text = projectUpdateVm.Name;
            txtDescription.Text = projectUpdateVm.Description;
            dtpEndDate.Value = projectUpdateVm.EndDate;
        }

        ProjectUpdateVm projectUpdate = new ProjectUpdateVm();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            projectUpdate.Id = ID;
            projectUpdate.Name = txtName.Text;
            projectUpdate.Description = txtDescription.Text;
            projectUpdate.EndDate = dtpEndDate.Value;

            _projectservice.Update(projectUpdate);

            _project.RefreshList();
        }

        
    }
}
