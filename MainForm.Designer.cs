namespace MainProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            ViewOfficeCreateForm = new ToolStripMenuItem();
            OfficeUpdateForm = new ToolStripMenuItem();
            ViewDeleteOffice = new ToolStripMenuItem();
            ViewAllOfiices = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            ViewCreateEmployee = new ToolStripMenuItem();
            ViewUpdateEmployee = new ToolStripMenuItem();
            ViewDeleteEmployee = new ToolStripMenuItem();
            ViewAllEmployees = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            ViewCreateProduct = new ToolStripMenuItem();
            ViewUpdateProduct = new ToolStripMenuItem();
            ViewDeleteProducts = new ToolStripMenuItem();
            View = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ViewCreateCustomer = new ToolStripMenuItem();
            ViewUpdateCustomer = new ToolStripMenuItem();
            ViewDeleteCustomer = new ToolStripMenuItem();
            ViewCustomers = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            ViewCreateOrder = new ToolStripMenuItem();
            ViewUpdateOrder = new ToolStripMenuItem();
            ViewDeleteOrder = new ToolStripMenuItem();
            ViewOrder = new ToolStripMenuItem();
            productLineToolStripMenuItem = new ToolStripMenuItem();
            ViewCreatePL = new ToolStripMenuItem();
            ViewUpdatePL = new ToolStripMenuItem();
            ViewDeletePL = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            ViewCreatePayment = new ToolStripMenuItem();
            ViewUpdatePayment = new ToolStripMenuItem();
            ViewDeletePAyment = new ToolStripMenuItem();
            ViewAllPayments = new ToolStripMenuItem();
            orderProductToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, viewToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, orderToolStripMenuItem, productLineToolStripMenuItem, paymentToolStripMenuItem, orderProductToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewOfficeCreateForm, OfficeUpdateForm, ViewDeleteOffice, ViewAllOfiices });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(63, 24);
            addToolStripMenuItem.Text = "Office";
            // 
            // ViewOfficeCreateForm
            // 
            ViewOfficeCreateForm.Name = "ViewOfficeCreateForm";
            ViewOfficeCreateForm.Size = new Size(141, 26);
            ViewOfficeCreateForm.Text = "Create";
            ViewOfficeCreateForm.Click += ViewOfficeCreateForm_Click;
            // 
            // OfficeUpdateForm
            // 
            OfficeUpdateForm.Name = "OfficeUpdateForm";
            OfficeUpdateForm.Size = new Size(141, 26);
            OfficeUpdateForm.Text = "Update";
            OfficeUpdateForm.Click += OfficeUpdateForm_Click;
            // 
            // ViewDeleteOffice
            // 
            ViewDeleteOffice.Name = "ViewDeleteOffice";
            ViewDeleteOffice.Size = new Size(141, 26);
            ViewDeleteOffice.Text = "Delete";
            ViewDeleteOffice.Click += ViewDeleteOffice_Click;
            // 
            // ViewAllOfiices
            // 
            ViewAllOfiices.Name = "ViewAllOfiices";
            ViewAllOfiices.Size = new Size(141, 26);
            ViewAllOfiices.Text = "View";
            ViewAllOfiices.Click += ViewAllOfiices_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreateEmployee, ViewUpdateEmployee, ViewDeleteEmployee, ViewAllEmployees });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(89, 24);
            viewToolStripMenuItem.Text = "Employee";
            // 
            // ViewCreateEmployee
            // 
            ViewCreateEmployee.Name = "ViewCreateEmployee";
            ViewCreateEmployee.Size = new Size(141, 26);
            ViewCreateEmployee.Text = "Create";
            ViewCreateEmployee.Click += ViewCreateEmployee_Click;
            // 
            // ViewUpdateEmployee
            // 
            ViewUpdateEmployee.Name = "ViewUpdateEmployee";
            ViewUpdateEmployee.Size = new Size(141, 26);
            ViewUpdateEmployee.Text = "Update";
            ViewUpdateEmployee.Click += ViewUpdateEmployee_Click;
            // 
            // ViewDeleteEmployee
            // 
            ViewDeleteEmployee.Name = "ViewDeleteEmployee";
            ViewDeleteEmployee.Size = new Size(141, 26);
            ViewDeleteEmployee.Text = "Delete";
            ViewDeleteEmployee.Click += ViewDeleteEmployee_Click;
            // 
            // ViewAllEmployees
            // 
            ViewAllEmployees.Name = "ViewAllEmployees";
            ViewAllEmployees.Size = new Size(141, 26);
            ViewAllEmployees.Text = "View";
            ViewAllEmployees.Click += ViewAllEmployees_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreateProduct, ViewUpdateProduct, ViewDeleteProducts, View });
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(74, 24);
            updateToolStripMenuItem.Text = "Product";
            // 
            // ViewCreateProduct
            // 
            ViewCreateProduct.Name = "ViewCreateProduct";
            ViewCreateProduct.Size = new Size(141, 26);
            ViewCreateProduct.Text = "Create";
            ViewCreateProduct.Click += ViewCreateProduct_Click;
            // 
            // ViewUpdateProduct
            // 
            ViewUpdateProduct.Name = "ViewUpdateProduct";
            ViewUpdateProduct.Size = new Size(141, 26);
            ViewUpdateProduct.Text = "Update";
            ViewUpdateProduct.Click += ViewUpdateProduct_Click;
            // 
            // ViewDeleteProducts
            // 
            ViewDeleteProducts.Name = "ViewDeleteProducts";
            ViewDeleteProducts.Size = new Size(141, 26);
            ViewDeleteProducts.Text = "Delete";
            ViewDeleteProducts.Click += ViewDeleteProducts_Click;
            // 
            // View
            // 
            View.Name = "View";
            View.Size = new Size(141, 26);
            View.Text = "View";
            View.Click += View_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreateCustomer, ViewUpdateCustomer, ViewDeleteCustomer, ViewCustomers });
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(86, 24);
            deleteToolStripMenuItem.Text = "Customer";
            // 
            // ViewCreateCustomer
            // 
            ViewCreateCustomer.Name = "ViewCreateCustomer";
            ViewCreateCustomer.Size = new Size(141, 26);
            ViewCreateCustomer.Text = "Create";
            ViewCreateCustomer.Click += ViewCreateCustomer_Click;
            // 
            // ViewUpdateCustomer
            // 
            ViewUpdateCustomer.Name = "ViewUpdateCustomer";
            ViewUpdateCustomer.Size = new Size(141, 26);
            ViewUpdateCustomer.Text = "Update";
            ViewUpdateCustomer.Click += ViewUpdateCustomer_Click;
            // 
            // ViewDeleteCustomer
            // 
            ViewDeleteCustomer.Name = "ViewDeleteCustomer";
            ViewDeleteCustomer.Size = new Size(141, 26);
            ViewDeleteCustomer.Text = "Delete";
            ViewDeleteCustomer.Click += ViewDeleteCustomer_Click;
            // 
            // ViewCustomers
            // 
            ViewCustomers.Name = "ViewCustomers";
            ViewCustomers.Size = new Size(141, 26);
            ViewCustomers.Text = "View";
            ViewCustomers.Click += ViewCustomers_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreateOrder, ViewUpdateOrder, ViewDeleteOrder, ViewOrder });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // ViewCreateOrder
            // 
            ViewCreateOrder.Name = "ViewCreateOrder";
            ViewCreateOrder.Size = new Size(141, 26);
            ViewCreateOrder.Text = "Create";
            ViewCreateOrder.Click += ViewCreateOrder_Click;
            // 
            // ViewUpdateOrder
            // 
            ViewUpdateOrder.Name = "ViewUpdateOrder";
            ViewUpdateOrder.Size = new Size(141, 26);
            ViewUpdateOrder.Text = "Update";
            ViewUpdateOrder.Click += ViewUpdateOrder_Click;
            // 
            // ViewDeleteOrder
            // 
            ViewDeleteOrder.Name = "ViewDeleteOrder";
            ViewDeleteOrder.Size = new Size(141, 26);
            ViewDeleteOrder.Text = "Delete";
            ViewDeleteOrder.Click += ViewDeleteOrder_Click;
            // 
            // ViewOrder
            // 
            ViewOrder.Name = "ViewOrder";
            ViewOrder.Size = new Size(141, 26);
            ViewOrder.Text = "View";
            ViewOrder.Click += ViewOrder_Click;
            // 
            // productLineToolStripMenuItem
            // 
            productLineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreatePL, ViewUpdatePL, ViewDeletePL, viewToolStripMenuItem1 });
            productLineToolStripMenuItem.Name = "productLineToolStripMenuItem";
            productLineToolStripMenuItem.Size = new Size(101, 24);
            productLineToolStripMenuItem.Text = "ProductLine";
            // 
            // ViewCreatePL
            // 
            ViewCreatePL.Name = "ViewCreatePL";
            ViewCreatePL.Size = new Size(141, 26);
            ViewCreatePL.Text = "Create";
            ViewCreatePL.Click += ViewCreatePL_Click;
            // 
            // ViewUpdatePL
            // 
            ViewUpdatePL.Name = "ViewUpdatePL";
            ViewUpdatePL.Size = new Size(141, 26);
            ViewUpdatePL.Text = "Update";
            ViewUpdatePL.Click += ViewUpdatePL_Click;
            // 
            // ViewDeletePL
            // 
            ViewDeletePL.Name = "ViewDeletePL";
            ViewDeletePL.Size = new Size(141, 26);
            ViewDeletePL.Text = "Delete";
            ViewDeletePL.Click += ViewDeletePL_Click;
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.AccessibleDescription = "ViewPL";
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(141, 26);
            viewToolStripMenuItem1.Text = "View";
            viewToolStripMenuItem1.Click += viewToolStripMenuItem1_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewCreatePayment, ViewUpdatePayment, ViewDeletePAyment, ViewAllPayments });
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(79, 24);
            paymentToolStripMenuItem.Text = "Payment";
            // 
            // ViewCreatePayment
            // 
            ViewCreatePayment.Name = "ViewCreatePayment";
            ViewCreatePayment.Size = new Size(141, 26);
            ViewCreatePayment.Text = "Create";
            ViewCreatePayment.Click += ViewCreatePayment_Click;
            // 
            // ViewUpdatePayment
            // 
            ViewUpdatePayment.Name = "ViewUpdatePayment";
            ViewUpdatePayment.Size = new Size(141, 26);
            ViewUpdatePayment.Text = "Update";
            ViewUpdatePayment.Click += ViewUpdatePayment_Click;
            // 
            // ViewDeletePAyment
            // 
            ViewDeletePAyment.Name = "ViewDeletePAyment";
            ViewDeletePAyment.Size = new Size(141, 26);
            ViewDeletePAyment.Text = "Delete";
            ViewDeletePAyment.Click += ViewDeletePAyment_Click;
            // 
            // ViewAllPayments
            // 
            ViewAllPayments.Name = "ViewAllPayments";
            ViewAllPayments.Size = new Size(141, 26);
            ViewAllPayments.Text = "View";
            ViewAllPayments.Click += ViewAllPayments_Click;
            // 
            // orderProductToolStripMenuItem
            // 
            orderProductToolStripMenuItem.Name = "orderProductToolStripMenuItem";
            orderProductToolStripMenuItem.Size = new Size(112, 24);
            orderProductToolStripMenuItem.Text = "OrderProduct";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 196);
            label1.Name = "label1";
            label1.Size = new Size(376, 52);
            label1.TabIndex = 3;
            label1.Text = "Welcome To My Sales System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem productLineToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem orderProductToolStripMenuItem;
        private ToolStripMenuItem ViewOfficeCreateForm;
        private ToolStripMenuItem OfficeUpdateForm;
        private ToolStripMenuItem ViewDeleteOffice;
        private ToolStripMenuItem ViewAllOfiices;
        private ToolStripMenuItem ViewCreateEmployee;
        private ToolStripMenuItem ViewUpdateEmployee;
        private ToolStripMenuItem ViewDeleteEmployee;
        private ToolStripMenuItem ViewAllEmployees;
        private ToolStripMenuItem ViewCreateProduct;
        private ToolStripMenuItem ViewUpdateProduct;
        private ToolStripMenuItem ViewDeleteProducts;
        private ToolStripMenuItem View;
        private ToolStripMenuItem ViewCreatePL;
        private ToolStripMenuItem ViewUpdatePL;
        private ToolStripMenuItem ViewDeletePL;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem ViewCreatePayment;
        private ToolStripMenuItem ViewUpdatePayment;
        private ToolStripMenuItem ViewDeletePAyment;
        private ToolStripMenuItem ViewAllPayments;
        private ToolStripMenuItem ViewCreateCustomer;
        private ToolStripMenuItem ViewUpdateCustomer;
        private ToolStripMenuItem ViewDeleteCustomer;
        private ToolStripMenuItem ViewCustomers;
        private ToolStripMenuItem ViewCreateOrder;
        private ToolStripMenuItem ViewUpdateOrder;
        private ToolStripMenuItem ViewDeleteOrder;
        private ToolStripMenuItem ViewOrder;
        private Label label1;
    }
}
