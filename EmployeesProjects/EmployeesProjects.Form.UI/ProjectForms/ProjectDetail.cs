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
    public partial class ProjectDetail : Form
    {
        int id;
        public ProjectDetail(int id)
        {
            InitializeComponent();
            this.id = id;
           
        }

        private void ProjectDetail_Load(object sender, EventArgs e)
        {
            ProjectDetailVm vm = new ProjectService().Detail(id);

            lblName.Text = vm.Name;
            lblDesc.Text = vm.Description;
            lblStart.Text=vm.StartDate.ToString();
            lblEnd.Text=vm.EndDate.ToString();
            lblEmpName.Text = vm.EmloyeeNames;
            lblEmpLastName.Text = vm.EmployeeLasNames;
          
        }
    }
}
