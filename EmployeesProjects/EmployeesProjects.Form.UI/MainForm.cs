using EmployeesProjects.Forms.UI.EmployeeForms;
using EmployeesProjects.Forms.UI.EmployeeProjectForms;
using EmployeesProjects.Forms.UI.ProjectForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesProjects.Forms.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeList form = new EmployeeList();
            form.ShowDialog();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectList form = new ProjectList();
            form.ShowDialog();
        }

        private void btnEmpProj_Click(object sender, EventArgs e)
        {
            EmployeeProjectList form = new EmployeeProjectList();
            form.ShowDialog();
        }
    }
}
