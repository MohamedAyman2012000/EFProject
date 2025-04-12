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
    public partial class FrmUpdateCustomer : Form
    {
        private ApplicationDbContext context;
        private List<Customer> CustLst;
        public FrmUpdateCustomer( bool IsDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            if (IsDeleted)
            {
                btnSave.Text = "Delete";
            }
            else
            {
                btnSave.Text = "Edit";
            }
            CustLst = context.Customers.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Cust = new Customer() { ID = -1 };
            if (cbCustomer.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbCustomer.SelectedValue.ToString());
                Cust = CustLst.FirstOrDefault(x => x.ID == selectedCode);
            }

            if (btnSave.Text == "Edit")
            {


                if (Cust.ID != -1)
                {
                    if (!int.TryParse(txtPostal.Text, out int result)&&txtPostal.Text.Trim()!="")
                    {
                        MessageBox.Show("Please enter numbers only in Postal Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(txtCreditLimit.Text, out decimal result2)&&txtCreditLimit.Text.Trim()!="")
                    {
                        MessageBox.Show("Please enter numbers only in Credit Limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if ((int)cbEmployee.SelectedValue == -1)
                    {
                        MessageBox.Show("Please Select Sales Employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Cust.Name = txtName.Text;
                    Cust.State = txtState.Text;
                    Cust.Country = txtCountry.Text;
                    Cust.Phone = txtPhone.Text;
                    Cust.City = txtCity.Text;
                    Cust.Address1 = txtAdd1.Text;
                    Cust.Address2 = txtAdd2.Text;
                    Cust.CreditLimit = (txtCreditLimit.Text.Trim()=="")?null:decimal.Parse(txtCreditLimit.Text);
                    Cust.PostalCode = (txtPostal.Text.Trim() == "") ? null : int.Parse(txtPostal.Text);
                    Cust.SalesRepEmployeeNum = int.Parse(cbEmployee.SelectedValue.ToString());
                    context.SaveChanges();
                    MessageBox.Show("Customer Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Cust.ID != -1)
                {
                    context.Customers.Remove(Cust);
                    context.SaveChanges();
                    MessageBox.Show("Customer Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUpdateCustomer_Load(object sender, EventArgs e)
        {
            CustLst.Insert(0, new Customer { ID = 10, Name = "-- Select Customer --" });
            cbCustomer.Items.Clear();
            cbCustomer.DataSource = CustLst;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            cbCustomer.SelectedIndex = 0;

            var Emps = context.Employees.ToList();
            Emps.Insert(0, new Employee { ID = -1, FirstName = "-- Select Employee --" });
            cbEmployee.Items.Clear();
            cbEmployee.DataSource = Emps;
            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "ID";
            cbEmployee.SelectedIndex = 0;

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbCustomer.SelectedValue.ToString());
                var Office = CustLst.FirstOrDefault(x => x.ID == selectedCode);

                if (Office != null)
                {
                    txtAdd1.Text = Office.Address1;
                    txtAdd2.Text = Office.Address2;
                    txtCity.Text = Office.City;
                    txtCountry.Text = Office.Country;
                    txtPhone.Text = Office.Phone;
                    txtPostal.Text = Office.PostalCode.ToString();
                    txtState.Text = Office.State;
                    txtCreditLimit.Text = Office.CreditLimit.ToString();
                    txtName.Text = Office.Name;
                    cbEmployee.SelectedValue = Office.SalesRepEmployeeNum;
                }

            }
        }
    }
}
