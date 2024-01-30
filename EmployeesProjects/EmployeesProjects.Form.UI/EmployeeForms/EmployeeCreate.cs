using EmployeesProjects.Bll.IServices;
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
    public partial class EmployeeCreate : Form
    {
        IEmployeeService _service;
        EmployeeList _employeeList;
        public EmployeeCreate(EmployeeList list)
        {
            InitializeComponent();
            
            _employeeList = list;
            _service = list.service;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) 
               )
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }



            EmployeeCreateVm vm = new EmployeeCreateVm();

            vm.Name = txtName.Text;
            vm.LastName= txtLastName.Text;
            vm.HireDate = dtHire.Value;
            vm.Note = txtNote.Text;
            _service.Create(vm);
            _employeeList.RefreshList();
        }
    }
}
