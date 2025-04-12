using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using DAL.Models;

namespace MainProject.CreateForms
{
    public partial class FrmCreateEmployee : Form
    {
        private ApplicationDbContext context;
        public FrmCreateEmployee()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateEmployee_Load(object sender, EventArgs e)
        {
            var Offices = context.Offices.ToList();
            var Emps = context.Employees.ToList();
            Offices.Insert(0, new Office { Code = 10, City = "-- Select Office --" });
            cbOffice.Items.Clear();
            cbOffice.DataSource = Offices;
            cbOffice.DisplayMember = "City";
            cbOffice.ValueMember = "Code";
            cbOffice.SelectedIndex = 0;

            Emps.Insert(0, new Employee { ID = -1, FirstName = "--Select Employee" });
            cbEmployee.Items.Clear();
            cbEmployee.DataSource = Emps;
            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "ID";
            cbEmployee.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            if (cbOffice.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any Office.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbEmployee.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any Manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int officeId = int.Parse(cbOffice.SelectedIndex.ToString());
            int EmpCode= int.Parse(cbEmployee.SelectedIndex.ToString());

            employee.FirstName= txtFName.Text;
            employee.LastName = txtLName.Text;
            employee.Email = txtEmail.Text;
            employee.Extension = txtExtension.Text;
            employee.JobTitle = txtJobTitle.Text;
            employee.OfficeCode = officeId;
            employee.ReportsTo = EmpCode;
            context.Employees.Add(employee);
            context.SaveChanges();
            MessageBox.Show("Employee Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
