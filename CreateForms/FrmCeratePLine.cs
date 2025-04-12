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
    public partial class FrmCeratePLine : Form
    {
        private ApplicationDbContext context;
        public FrmCeratePLine()
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
            var PL = new Productline();
            PL.DescriptionHTML = txtHTML.Text;
            PL.DescriptionText = txtText.Text;
            PL.Image = txtImage.Text;
            context.Productlines.Add(PL);
            context.SaveChanges();
            MessageBox.Show("ProductLine Is Saved Successfully", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
