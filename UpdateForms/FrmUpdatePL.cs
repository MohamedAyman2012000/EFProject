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
    public partial class FrmUpdatePL : Form
    {
        private ApplicationDbContext context;
        private List<Productline> products;
        public FrmUpdatePL(bool isDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            products = context.Productlines.ToList();
            if (isDeleted)
            {
                btnSave.Text = "Delete";
            }
            else
            {
                btnSave.Text = "Edit";
            }
        }

        private void FrmUpdatePL_Load(object sender, EventArgs e)
        {

            products.Insert(0, new Productline { ID = -1, DescriptionText = "-- Select ProductLine --" });
            cbPL.Items.Clear();
            cbPL.DataSource = products;
            cbPL.DisplayMember = "DescriptionText";
            cbPL.ValueMember = "ID";
            cbPL.SelectedIndex = 0;
        }

        private void cbPL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPL.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbPL.SelectedValue.ToString());
                var PL = products.FirstOrDefault(x => x.ID == selectedCode);

                if (PL != null)
                {
                    txtHTML.Text = PL.DescriptionHTML;
                    txtText.Text = PL.DescriptionText;
                    txtImage.Text = PL.Image;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var PL = new Productline() { ID = -1 };
            if (cbPL.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbPL.SelectedValue.ToString());
                PL = products.FirstOrDefault(x => x.ID == selectedCode);
            }

            if (btnSave.Text == "Edit")
            {
                if (PL.ID != -1)
                {

                   PL.DescriptionHTML = txtHTML.Text;
                   PL.DescriptionText = txtText.Text;
                   PL.Image = txtImage.Text;

                    context.SaveChanges();
                    MessageBox.Show("ProductLine Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any ProductLine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (PL.ID != -1)
                {
                    context.Productlines.Remove(PL);
                    context.SaveChanges();
                    MessageBox.Show("ProductLine Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any ProductLine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
