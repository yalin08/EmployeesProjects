using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Bll.Services;
using EmployeesProjects.Entities;
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
    public partial class ProjectCreate : Form
    {
        IProjectService _projectservice;

        public ProjectCreate()
        {
            InitializeComponent();
            _projectservice = new ProjectService();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProjectCreateVm project = new ProjectCreateVm()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            _projectservice.Create(project);
        }
    }
}
