using DAL.Context;
using MainProject.CreateForms;
using MainProject.UpdateForms;
using MainProject.ViewForms;
using Microsoft.EntityFrameworkCore;

namespace MainProject
{
    public partial class MainForm : Form
    {
        private ApplicationDbContext context;
        public MainForm()
        {
            context = new ApplicationDbContext();
            InitializeComponent();
        }

        private void ViewOfficeCreateForm_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateOffice();
            frm.ShowDialog();
        }

        private void OfficeUpdateForm_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateOffice(this);
            frm.ShowDialog();
        }

        private void ViewDeleteOffice_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateOffice(this, true);
            frm.ShowDialog();
        }

        private void ViewAllOfiices_Click(object sender, EventArgs e)
        {
            var OfficeLst = context.Offices.ToList();
            var frm = new ViewAll(OfficeLst);
            frm.ShowDialog();
        }

        private void ViewCreateEmployee_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateEmployee();
            frm.ShowDialog();
        }

        private void ViewAllEmployees_Click(object sender, EventArgs e)
        {
            var EmpList = context.Employees.ToList();
            var frm = new ViewAll(EmpList);
            frm.ShowDialog();
        }

        private void ViewUpdateEmployee_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateEmployee();
            frm.ShowDialog();
        }

        private void ViewDeleteEmployee_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateEmployee(true);
            frm.ShowDialog();
        }

        private void ViewCreateProduct_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateProduct();
            frm.ShowDialog();
        }

        private void View_Click(object sender, EventArgs e)
        {
            var Products = context.Products.ToList();
            var frm = new ViewAll(Products);
            frm.ShowDialog();
        }

        private void ViewUpdateProduct_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateProduct();
            frm.ShowDialog();
        }

        private void ViewDeleteProducts_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateProduct(true);
            frm.ShowDialog();
        }

        private void ViewCreatePL_Click(object sender, EventArgs e)
        {
            var frm = new FrmCeratePLine();
            frm.ShowDialog();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ProductLines = context.Productlines.ToList();
            var frm = new ViewAll(ProductLines);
            frm.ShowDialog();
        }

        private void ViewUpdatePL_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdatePL();
            frm.ShowDialog();
        }

        private void ViewDeletePL_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdatePL(true);
            frm.ShowDialog();
        }

        private void ViewCreatePayment_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreatePayment();
            frm.ShowDialog();
        }

        private void ViewAllPayments_Click(object sender, EventArgs e)
        {
            var Payments = context.Payments.ToList();
            var frm = new ViewAll(Payments);
            frm.ShowDialog();
        }

        private void ViewUpdatePayment_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdatePayment();
            frm.ShowDialog();
        }

        private void ViewDeletePAyment_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdatePayment(true);
            frm.ShowDialog();
        }

        private void ViewCreateCustomer_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateCustomer();
            frm.ShowDialog();
        }

        private void ViewCustomers_Click(object sender, EventArgs e)
        {
            var Customers = context.Customers.ToList();
            var frm = new ViewAll(Customers);
            frm.ShowDialog();
        }

        private void ViewUpdateCustomer_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateCustomer();
            frm.ShowDialog();
        }

        private void ViewDeleteCustomer_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateCustomer(true);
            frm.ShowDialog();
        }

        private void ViewCreateOrder_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateOrder();
            frm.ShowDialog();
        }

        private void ViewDeleteOrder_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateOrder(true);
            frm.ShowDialog();
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            var orders = context.Orders.ToList();
            var frm = new ViewAll(orders);
            frm.ShowDialog();
        }

        private void ViewUpdateOrder_Click(object sender, EventArgs e)
        {
            var frm = new FrmUpdateOrder();
            frm.ShowDialog();
        }
    }
}
