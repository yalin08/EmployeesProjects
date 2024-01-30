using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Bll.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesProjects.Forms.UI.EmployeeProjectForms
{
    public partial class EmployeeProjectList : Form
    {
        IEmployeeProjectService _employeeProject;
        public EmployeeProjectList()
        {
            InitializeComponent();
            _employeeProject = new EmployeeProjectService();
        }

        private void EmployeeProjectList_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeProjectCreate form = new EmployeeProjectCreate();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeProjectUpdate form = new EmployeeProjectUpdate();
            form.ShowDialog();
        }
        public void RefreshList()
        { 
        }
    }
}
