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
    public partial class FrmCreateCustomer : Form
    {
        private ApplicationDbContext context;
        public FrmCreateCustomer()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            if (!int.TryParse(txtPostal.Text, out int result) && txtPostal.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Postal Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(txtCreditLimit.Text, out decimal result2) && txtCreditLimit.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Credit Limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((int)cbEmployee.SelectedValue==-1)
            {
                MessageBox.Show("Please Select Sales Employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customer.Name = txtName.Text;
            customer.State = txtState.Text;
            customer.Country = txtCountry.Text;
            customer.Phone = txtPhone.Text;
            customer.City = txtCity.Text;
            customer.Address1 = txtAdd1.Text;
            customer.Address2 = txtAdd2.Text;
            customer.CreditLimit = txtCreditLimit.Text.Trim() == "" ? null : decimal.Parse(txtCreditLimit.Text);
            customer.PostalCode = txtPostal.Text.Trim() == "" ? null : int.Parse(txtPostal.Text);
            customer.SalesRepEmployeeNum = int.Parse(cbEmployee.SelectedValue.ToString());
            context.Customers.Add(customer);
            context.SaveChanges();
            MessageBox.Show("Customers Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCreateCustomer_Load(object sender, EventArgs e)
        {
            var Emps = context.Employees.ToList();
            Emps.Insert(0, new Employee { ID = -1, FirstName = "-- Select Employee --" });
            cbEmployee.Items.Clear();
            cbEmployee.DataSource = Emps;
            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "ID";
            cbEmployee.SelectedIndex = 0;
        }
    }
}
