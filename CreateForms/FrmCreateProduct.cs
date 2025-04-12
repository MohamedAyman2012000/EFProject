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
    public partial class FrmCreateProduct : Form
    {
        private ApplicationDbContext context;
        public FrmCreateProduct()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCreateProduct_Load(object sender, EventArgs e)
        {
            var PLineLst = context.Productlines.ToList();
            PLineLst.Insert(0, new Productline { ID = 10, DescriptionText = "-- Select Office --" });
            cbProductLine.Items.Clear();
            cbProductLine.DataSource = PLineLst;
            cbProductLine.DisplayMember = "DescriptionText";
            cbProductLine.ValueMember = "ID";
            cbProductLine.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Product = new Product();
            if (cbProductLine.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Any ProductLine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            int PlId = int.Parse(cbProductLine.SelectedIndex.ToString());

            if (!int.TryParse(txtScale.Text, out int result) && txtScale.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Scale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQtyInStock.Text, out int result2) && txtQtyInStock.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Quntity in Stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBuyPrice.Text, out int result3) && txtBuyPrice.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Scale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product.Scale = (txtScale.Text.Trim() == "")?null:int.Parse(txtScale.Text);
            Product.MSRP = txtMSRP.Text;
            Product.Name = txtName.Text;
            Product.Vendor = txtVendor.Text;
            Product.BuyPrice = (txtBuyPrice.Text.Trim() == "")?null:decimal.Parse(txtBuyPrice.Text);
            Product.QuantityInStock = (txtQtyInStock.Text.Trim() == "")?null:int.Parse(txtQtyInStock.Text);
            Product.PdtDescription = txtDescription.Text;
            Product.ProductlineID = PlId;
            context.Products.Add(Product);
            context.SaveChanges();
            MessageBox.Show("Product Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
