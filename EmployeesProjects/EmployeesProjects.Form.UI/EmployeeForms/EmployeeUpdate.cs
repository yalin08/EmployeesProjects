using EmployeesProjects.Bll.IServices;
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
    public partial class EmployeeUpdate : Form
    {
        EmployeeList _employees;
        private EmployeeUpdateVm uvm;

        public EmployeeUpdate(EmployeeList list, EmployeeUpdateVm uvm)
        {
            InitializeComponent();
            _employees = list;
            this.uvm = uvm;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtName.Text)
              )
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }

            EmployeeUpdateVm update= new EmployeeUpdateVm();
            update.ID = uvm.ID;
            update.Name = txtName.Text;
            update.LastName = txtLastName.Text;
            update.Note = txtNote.Text;

             new EmployeeService().Update(update);


            _employees.RefreshList();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = uvm.Name;
            txtLastName.Text = uvm.LastName;
            txtNote.Text = uvm.Note;
        }
    }
}
