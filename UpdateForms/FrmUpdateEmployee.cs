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

namespace MainProject.UpdateForms
{
    public partial class FrmUpdateEmployee : Form
    {
        private ApplicationDbContext context;
        private List<Employee> EmpLst;
        private List<Office> OfficeLst;
        public FrmUpdateEmployee(bool IsDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            if (IsDeleted)
            {
                btnEdit.Text = "Delete";
            }
            else
            {
                btnEdit.Text = "Edit";
            }
            EmpLst = context.Employees.ToList();
            OfficeLst = context.Offices.ToList();
        }


        private void FrmUpdateEmployee_Load(object sender, EventArgs e)
        {
            EmpLst.Insert(0, new Employee { ID = -1, FirstName = "-- Select Employee --" });
            cbMainEmp.Items.Clear();
            cbMainEmp.DataSource = EmpLst;
            cbMainEmp.DisplayMember = "FirstName";
            cbMainEmp.ValueMember = "ID";
            cbMainEmp.SelectedIndex = 0;

            OfficeLst.Insert(0, new Office { Code = 10, City = "-- Select Office --" });
            cbOffice.Items.Clear();
            cbOffice.DataSource = OfficeLst;
            cbOffice.DisplayMember = "City";
            cbOffice.ValueMember = "Code";
            cbOffice.SelectedValue = 0;

            var emps = context.Employees.ToList();

            cbEmployee.Items.Clear();
            cbEmployee.DataSource = emps;
            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "ID";
            cbEmployee.SelectedValue = 0;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbMainEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMainEmp.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbMainEmp.SelectedValue.ToString());
                var Emp = EmpLst.FirstOrDefault(x => x.ID == selectedCode);

                if (Emp != null)
                {
                    txtEmail.Text = Emp.Email;
                    txtFName.Text = Emp.FirstName;
                    txtLName.Text = Emp.LastName;
                    txtJobTitle.Text = Emp.JobTitle;
                    txtExtension.Text = Emp.Extension;
                    cbOffice.SelectedValue = Emp.OfficeCode;
                    cbEmployee.SelectedValue = Emp.ReportsTo;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var Emp = new Employee() { ID = -1 };
            if (cbMainEmp.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbMainEmp.SelectedValue.ToString());
                Emp = EmpLst.FirstOrDefault(x => x.ID == selectedCode);
            }

            if (btnEdit.Text == "Edit")
            {
                if (Emp.ID != -1)
                {

                    Emp.FirstName = txtFName.Text;
                    Emp.LastName = txtLName.Text;
                    Emp.Email = txtEmail.Text;
                    Emp.JobTitle = txtJobTitle.Text;
                    Emp.Extension = txtExtension.Text;
                    Emp.OfficeCode = int.Parse(cbOffice.SelectedValue.ToString());
                    Emp.ReportsTo = int.Parse(cbEmployee.SelectedValue.ToString());

                    context.SaveChanges();
                    MessageBox.Show("Employee Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Emp.ID != -1)
                {
                    context.Employees.Remove(Emp);
                    context.SaveChanges();
                    MessageBox.Show("Employee Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
