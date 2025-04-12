using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DAL.Context;
using DAL.Models;

namespace MainProject.UpdateForms
{
    public partial class FrmUpdatePayment : Form
    {
        private List<Payment> paymentList;
        private ApplicationDbContext context;
        public FrmUpdatePayment(bool isDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            paymentList = context.Payments.ToList();

            if (isDeleted)
            {
                btnSave.Text = "Delete";
            }
            else
            {
                btnSave.Text = "Edit";
            }
        }

        private void FrmUpdatePayment_Load(object sender, EventArgs e)
        {
            var custs = context.Customers.ToList();
            custs.Insert(0, new Customer { ID = 10, Name = "-- Select Customer --" });
            cbCustomer.Items.Clear();
            cbCustomer.DataSource = custs;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            cbCustomer.SelectedIndex = 0;


            paymentList.Insert(0, new Payment { CheckNum = -1, Desc = "-- Select Payment --" });
            cbPayments.Items.Clear();
            cbPayments.DataSource = paymentList;
            cbPayments.DisplayMember = "Desc";
            cbPayments.ValueMember = "CheckNum";
            cbPayments.SelectedIndex = 0;
        }

        private void cbPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayments.SelectedIndex >= 0)
            {
                if (cbPayments.SelectedValue is int selectedCode)
                {
                    var payment = paymentList.FirstOrDefault(x => x.CheckNum == selectedCode);
                    if (payment != null)
                    {
                        txtAmount.Text = payment.Amount.ToString();
                        dateTimePicker1.Value = payment.PaymentDate ?? DateTime.Now;
                        cbCustomer.SelectedValue = payment.CustomerID;
                        txtDesc.Text = payment.Desc;
                    }
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var payment = new Payment() { CheckNum = -1 };
            if (cbPayments.SelectedIndex >= 0)
            {
                int selectedCode = int.Parse(cbPayments.SelectedValue.ToString());
                payment = paymentList.FirstOrDefault(x => x.CheckNum == selectedCode);
            }

            if (btnSave.Text == "Edit")
            {
                if (payment.CheckNum != -1)
                {

                   payment.Amount = (txtAmount.Text.Trim() == "") ? null : decimal.Parse(txtAmount.Text);
                   payment.CustomerID = int.Parse(cbCustomer.SelectedValue.ToString());
                   payment.PaymentDate = dateTimePicker1.Value;
                   payment.Desc = txtDesc.Text;

                    context.SaveChanges();
                    MessageBox.Show("Payment Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (payment.CheckNum != -1)
                {
                    context.Payments.Remove(payment);
                    context.SaveChanges();
                    MessageBox.Show("Payment Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
