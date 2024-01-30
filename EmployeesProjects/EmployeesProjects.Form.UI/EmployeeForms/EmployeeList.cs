using EmployeesProjects.Bll.IServices;
using EmployeesProjects.Bll.Services;
using EmployeesProjects.Entities;
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
    public partial class EmployeeList : Form
    {
        public IEmployeeService service;
        public EmployeeList()
        {
            InitializeComponent();
            service = new EmployeeService();
            RefreshList();
        }
        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }
        public void RefreshList()
        {
            service = new EmployeeService();
            dgvEmployee.DataSource = service.GetAll();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeCreate form = new EmployeeCreate(this);
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }
            EmployeeListVm lvm = (EmployeeListVm)(dgvEmployee.SelectedRows[0].DataBoundItem);

            EmployeeUpdateVm uvm = new EmployeeUpdateVm()
            {
                ID = lvm.ID,
                Name = lvm.Name,
                LastName = lvm.LastName,
                Note = service.Detail(lvm.ID).Note
            };
            EmployeeUpdate form = new EmployeeUpdate(this, uvm);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }

            EmployeeListVm vm = (EmployeeListVm)(dgvEmployee.SelectedRows[0].DataBoundItem);
            int id = vm.ID;
            service.Delete(id);

            RefreshList();
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select from list");
                return;
            }
            EmployeeListVm vm = (EmployeeListVm)(dgvEmployee.SelectedRows[0].DataBoundItem);
            int id = vm.ID;
            EmployeeDetails form = new EmployeeDetails(id);
            form.Show();
        }


    }
}
