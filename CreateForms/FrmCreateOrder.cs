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
    public partial class FrmCreateOrder : Form
    {
        private ApplicationDbContext context;
        public FrmCreateOrder()
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
            var Order = new Order();
            if (cbCustomer.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int custID = int.Parse(cbCustomer.SelectedValue.ToString());

            Order.OrderDate = dtpOrderDate.Value;
            Order.RequiredDate = dtpRequireDate.Value;
            Order.ShippedDate = dtpSippingDate.Value;
            Order.Status = (txtStatus.Text.Trim() == "") ? null : int.Parse(txtStatus.Text);
            Order.Comments = txtComment.Text.Trim();
            Order.CustomerID = custID;

            context.Orders.Add(Order);
            context.SaveChanges();
            MessageBox.Show("Order Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCreateOrder_Load(object sender, EventArgs e)
        {
            var Custs = context.Customers.ToList();
            Custs.Insert(0, new Customer { ID = -1, Name = "-- Select Customer --" });
            cbCustomer.Items.Clear();
            cbCustomer.DataSource = Custs;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            cbCustomer.SelectedIndex = 0;
        }
    }
}
