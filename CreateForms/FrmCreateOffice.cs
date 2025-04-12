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
    public partial class FrmCreateOffice : Form
    {

        private ApplicationDbContext context;
        public FrmCreateOffice()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Office = new Office();
            if (!int.TryParse(txtPostal.Text, out int result) && txtPostal.Text.Trim() != "")
            {
                MessageBox.Show("Please enter numbers only in Postal Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Office.State = txtState.Text;
            Office.Country = txtCountry.Text;
            Office.Phone = txtPhone.Text;
            Office.City = txtCity.Text;
            Office.Address1 = txtAdd1.Text;
            Office.Address2 = txtAdd2.Text;
            Office.Territory = txtTerritory.Text;
            Office.PostalCode = txtPostal.Text.Trim() == "" ? null : int.Parse(txtPostal.Text);
            context.Offices.Add(Office);
            context.SaveChanges();
            MessageBox.Show("Office Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCreateOffice_Load(object sender, EventArgs e)
        {

        }
    }
}
