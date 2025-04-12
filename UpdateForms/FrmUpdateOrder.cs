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
    public partial class FrmUpdateOrder : Form
    {
        private ApplicationDbContext context;
        private List<Order> orders;
        public FrmUpdateOrder(bool IsDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            orders = context.Orders.ToList();
            if (IsDeleted)
            {
                btnSave.Text = "Delete";
            }
            else
            {
                btnSave.Text = "Edit";
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUpdateOrder_Load(object sender, EventArgs e)
        {
            var Custs = context.Customers.ToList();
            Custs.Insert(0, new Customer { ID = -1, Name = "-- Select Customer --" });
            cbCustomer.Items.Clear();
            cbCustomer.DataSource = Custs;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "ID";
            cbCustomer.SelectedIndex = 0;

            
            orders.Insert(0, new Order { ID = -1, Comments = "-- Select Order --" });
            cbOrders.Items.Clear();
            cbOrders.DataSource = orders;
            cbOrders.DisplayMember = "Comments";
            cbOrders.ValueMember = "ID";
            cbOrders.SelectedIndex = 0;

        }

        private void cbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrders.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbOrders.SelectedValue.ToString());
                var order = orders.FirstOrDefault(x => x.ID == selectedCode);

                if (order != null)
                {
                    txtComment.Text = order.Comments;
                    txtStatus.Text = order.Status.ToString();
                    dtpOrderDate.Value = (DateTime)order.OrderDate;
                    dtpSippingDate.Value = (DateTime)order.ShippedDate;
                    dtpRequireDate.Value = (DateTime)order.RequiredDate;
                    cbCustomer.SelectedValue = order.CustomerID;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Ord = new Order() { ID = -1 };
            if (cbOrders.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbOrders.SelectedValue.ToString());
                Ord = orders.FirstOrDefault(x => x.ID == selectedCode);
            }

            if (btnSave.Text == "Edit")
            {


                if (Ord.ID != -1)
                {
                    if (!int.TryParse(txtStatus.Text, out int result) && txtStatus.Text.Trim() != "")
                    {
                        MessageBox.Show("Please enter numbers only in Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                  
                    if ((int)cbCustomer.SelectedValue == -1)
                    {
                        MessageBox.Show("Please Select Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Ord.Comments = txtComment.Text;
                    Ord.Status = (txtStatus.Text.Trim() == "") ? null : int.Parse(txtStatus.Text);
                    Ord.OrderDate = dtpOrderDate.Value;
                    Ord.ShippedDate = dtpSippingDate.Value;
                    Ord.RequiredDate = dtpRequireDate.Value;
                    Ord.CustomerID = int.Parse(cbCustomer.SelectedValue.ToString());
                    context.SaveChanges();
                    MessageBox.Show("Order Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Ord.ID != -1)
                {
                    context.Orders.Remove(Ord);
                    context.SaveChanges();
                    MessageBox.Show("Order Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
