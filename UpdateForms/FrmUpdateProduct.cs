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
    public partial class FrmUpdateProduct : Form
    {
        private ApplicationDbContext context;
        private List<Product> products;
        public FrmUpdateProduct(bool isDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            products = context.Products.ToList();
            if (isDeleted)
            {
                btnSave.Text = "Delete";
            }
            else
            {
                btnSave.Text = "Edit";
            }
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            var PLineLst = context.Productlines.ToList();
            PLineLst.Insert(0, new Productline { ID = 10, DescriptionText = "-- Select Office --" });
            cbProductLine.Items.Clear();
            cbProductLine.DataSource = PLineLst;
            cbProductLine.DisplayMember = "DescriptionText";
            cbProductLine.ValueMember = "ID";
            cbProductLine.SelectedIndex = 0;


            products.Insert(0, new Product { Code = 10, Name = "-- Select Office --" });
            cbProducts.Items.Clear();
            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Code";
            cbProducts.SelectedIndex = 0;

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var prod = new Product() { Code = -1 };
            if (cbProducts.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbProducts.SelectedValue.ToString());
                prod = products.FirstOrDefault(x => x.Code == selectedCode);
            }

            if (btnSave.Text == "Edit")
            {
                if (prod.Code != -1)
                {

                    prod.Name = txtName.Text;
                    prod.Vendor = txtVendor.Text;
                    prod.QuantityInStock = (txtQtyInStock.Text.Trim()=="")?null:int.Parse(txtQtyInStock.Text);
                    prod.MSRP = txtMSRP.Text;
                    prod.BuyPrice = (txtBuyPrice.Text.Trim() == "") ? null : decimal.Parse(txtBuyPrice.Text);
                    prod.Scale = (txtScale.Text.Trim() == "") ? null : int.Parse(txtScale.Text);
                    prod.PdtDescription = txtDescription.Text;
                    prod.ProductlineID = int.Parse(cbProductLine.SelectedValue.ToString());

                    context.SaveChanges();
                    MessageBox.Show("Product Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (prod.Code != -1)
                {
                    context.Products.Remove(prod);
                    context.SaveChanges();
                    MessageBox.Show("Product Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbProducts.SelectedValue.ToString());
                var Prod = products.FirstOrDefault(x => x.Code == selectedCode);

                if (Prod != null)
                {
                    txtBuyPrice.Text = Prod.BuyPrice.ToString();
                    txtDescription.Text = Prod.PdtDescription;
                    txtName.Text = Prod.Name;
                    txtQtyInStock.Text = Prod.QuantityInStock.ToString();
                    txtMSRP.Text = Prod.MSRP;
                    txtScale.Text = Prod.Scale.ToString();
                    txtVendor.Text = Prod.Vendor;
                    cbProductLine.SelectedValue = Prod.ProductlineID;
                    
                }
            }
        }
    }
}
