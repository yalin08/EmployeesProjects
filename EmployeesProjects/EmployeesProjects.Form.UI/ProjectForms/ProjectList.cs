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
    public partial class ProjectList : Form
    {
        IProjectService _projectservice;

        public ProjectList()
        {
            InitializeComponent();
            _projectservice = new ProjectService();
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            _projectservice = new ProjectService();
            dvgGetAll.DataSource = _projectservice.GetAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProjectCreate projectCreate = new ProjectCreate(this);
            projectCreate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgGetAll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }
            ProjectListVm project = dvgGetAll.SelectedRows[0].DataBoundItem as ProjectListVm;

            ProjectUpdateVm projectUpdateVm = new ProjectUpdateVm()
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                EndDate = project.EndDate
            };

            ProjectUpdate projectUpdate = new ProjectUpdate(projectUpdateVm, this);
            projectUpdate.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgGetAll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }
            ProjectListVm project = dvgGetAll.SelectedRows[0].DataBoundItem as ProjectListVm;
            _projectservice.Delete(project.Id);
            RefreshList();

        }

        private void dvgGetAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dvgGetAll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }

            ProjectListVm projectListVm = new ProjectListVm();
            projectListVm = dvgGetAll.SelectedRows[0].DataBoundItem as ProjectListVm;

            ProjectDetail projectDetailShow = new ProjectDetail(projectListVm.Id);
            projectDetailShow.ShowDialog();
        }
    }
}
