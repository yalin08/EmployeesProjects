using EmployeesProjects.Bll.Services;
using EmployeesProjects.ViewModels.EmployeeVms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesProjects.Forms.UI.EmployeeForms
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails(int id)
        {
            InitializeComponent();

            EmployeeDetailVm vm = new EmployeeService().Detail(id);
            lblHire.Text= vm.HireDate.ToString();
            lblName.Text= vm.Name;
            lblLastName.Text= vm.LastName;
            lblNote.Text= vm.Note;
            lblProjects.Text = vm.ProjectNames;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
        }
    }
}
