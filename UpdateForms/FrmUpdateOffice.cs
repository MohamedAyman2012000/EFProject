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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainProject.UpdateForms
{
    public partial class FrmUpdateOffice : Form
    {
        private ApplicationDbContext context;
        private List<Office> OfficeLst;
        public FrmUpdateOffice(MainForm main, bool IsDeleted = false)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            if (IsDeleted)
            {
                btnEdit.Text = "Delete";
            }
            else
            {
                btnEdit.Text = "Edit";
            }
            OfficeLst = context.Offices.ToList();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdateOffice_Load(object sender, EventArgs e)
        {

            OfficeLst.Insert(0, new Office { Code = 10, City = "-- Select Office --" });
            cbOffice.Items.Clear();
            cbOffice.DataSource = OfficeLst;
            cbOffice.DisplayMember = "City";
            cbOffice.ValueMember = "Code";
            cbOffice.SelectedIndex = 0;

        }

        private void cbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOffice.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbOffice.SelectedValue.ToString());
                var Office = OfficeLst.FirstOrDefault(x => x.Code == selectedCode);

                if (Office != null)
                {
                    txtAdd1.Text = Office.Address1;
                    txtAdd2.Text = Office.Address2;
                    txtCity.Text = Office.City;
                    txtCountry.Text = Office.Country;
                    txtPhone.Text = Office.Phone;
                    txtPostal.Text = Office.PostalCode.ToString();
                    txtState.Text = Office.State;
                    txtTerritory.Text = Office.Territory;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var Office = new Office() { Code=-1};
            if (cbOffice.SelectedIndex > 0)
            {
                int selectedCode = int.Parse(cbOffice.SelectedValue.ToString());
                Office = OfficeLst.FirstOrDefault(x => x.Code == selectedCode);
            }

            if (btnEdit.Text == "Edit")
            {
               
                
                if (Office.Code != -1)
                {
                    if (!int.TryParse(txtPostal.Text, out int result))
                    {
                        MessageBox.Show("Please enter numbers only in Postal Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Office.State =txtState.Text;
                    Office.Country =txtCountry.Text;
                    Office.Phone = txtPhone.Text;
                    Office.City = txtCity.Text;
                    Office.Address1 = txtAdd1.Text;
                    Office.Address2 = txtAdd2.Text;
                    Office.Territory = txtTerritory.Text;
                    Office.PostalCode = int.Parse(txtPostal.Text);
                    context.SaveChanges();
                    MessageBox.Show("Office Is Updated Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Office.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Office.Code != -1)
                {
                    context.Offices.Remove(Office);
                    context.SaveChanges();
                    MessageBox.Show("Office Is Deleted Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Any Office.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
