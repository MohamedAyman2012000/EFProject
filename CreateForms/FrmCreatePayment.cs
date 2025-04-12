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
    public partial class FrmCreatePayment : Form
    {
        private ApplicationDbContext context;
        public FrmCreatePayment()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCreatePayment_Load(object sender, EventArgs e)
        {
            var customers = context.Customers.ToList();
            customers.Insert(0, new Customer { ID = 10, Name = "-- Select Customer --" });
            cbCustomer.Items.Clear();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            cbCustomer.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           var payment = new Payment();
           if (cbCustomer.SelectedIndex == 0)
           {
               MessageBox.Show("Please Select Any Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
           
           int custID = int.Parse(cbCustomer.SelectedIndex.ToString());

           payment.PaymentDate = dateTimePicker1.Value;
           payment.Desc= txtDesc.Text;
           payment.Amount =(txtAmount.Text.Trim()=="")?null:decimal.Parse( txtAmount.Text);
           payment.CustomerID = custID;
          
           context.Payments.Add(payment);
           context.SaveChanges();
           MessageBox.Show("Payment Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
