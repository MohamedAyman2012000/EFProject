using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.ViewForms
{
    public partial class ViewAll : Form
    {
        IEnumerable<object> List;
        public ViewAll(dynamic lst)
        {
            InitializeComponent();
            dgv.DataSource = lst;
            List = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            var name = List.First().GetType().Name+"s";
            label1.Text += name;
        }
    }
}
