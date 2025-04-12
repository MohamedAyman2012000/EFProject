namespace MainProject.UpdateForms
{
    partial class FrmUpdateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btBack = new Button();
            btnSave = new Button();
            cbCustomer = new ComboBox();
            Customer = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            txtComment = new TextBox();
            label5 = new Label();
            dtpSippingDate = new DateTimePicker();
            label3 = new Label();
            dtpRequireDate = new DateTimePicker();
            label2 = new Label();
            dtpOrderDate = new DateTimePicker();
            label1 = new Label();
            cbOrders = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(472, 441);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 77;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(272, 441);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 76;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(293, 92);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(337, 37);
            cbCustomer.TabIndex = 75;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.Location = new Point(188, 92);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 29);
            Customer.TabIndex = 74;
            Customer.Text = "Customer";
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(293, 322);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(337, 29);
            txtStatus.TabIndex = 73;
            txtStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 322);
            label4.Name = "label4";
            label4.Size = new Size(54, 29);
            label4.TabIndex = 72;
            label4.Text = "Status";
            // 
            // txtComment
            // 
            txtComment.BorderStyle = BorderStyle.None;
            txtComment.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(292, 374);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(337, 29);
            txtComment.TabIndex = 71;
            txtComment.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(187, 374);
            label5.Name = "label5";
            label5.Size = new Size(76, 29);
            label5.TabIndex = 70;
            label5.Text = "Comment";
            // 
            // dtpSippingDate
            // 
            dtpSippingDate.CustomFormat = "yyyy-MM-dd";
            dtpSippingDate.Font = new Font("Cairo", 9F);
            dtpSippingDate.Format = DateTimePickerFormat.Custom;
            dtpSippingDate.Location = new Point(293, 263);
            dtpSippingDate.Name = "dtpSippingDate";
            dtpSippingDate.Size = new Size(337, 36);
            dtpSippingDate.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 269);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 68;
            label3.Text = "Shipping Date";
            // 
            // dtpRequireDate
            // 
            dtpRequireDate.CustomFormat = "yyyy-MM-dd";
            dtpRequireDate.Font = new Font("Cairo", 9F);
            dtpRequireDate.Format = DateTimePickerFormat.Custom;
            dtpRequireDate.Location = new Point(293, 206);
            dtpRequireDate.Name = "dtpRequireDate";
            dtpRequireDate.Size = new Size(337, 36);
            dtpRequireDate.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 206);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 66;
            label2.Text = "Require Date";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy-MM-dd";
            dtpOrderDate.Font = new Font("Cairo", 9F);
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(293, 146);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(337, 36);
            dtpOrderDate.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 146);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 64;
            label1.Text = "Order Date";
            // 
            // cbOrders
            // 
            cbOrders.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(292, 33);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(337, 37);
            cbOrders.TabIndex = 79;
            cbOrders.SelectedIndexChanged += cbOrders_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(176, 36);
            label6.Name = "label6";
            label6.Size = new Size(110, 29);
            label6.TabIndex = 78;
            label6.Text = "Select an Order";
            // 
            // FrmUpdateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(cbOrders);
            Controls.Add(label6);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(cbCustomer);
            Controls.Add(Customer);
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(txtComment);
            Controls.Add(label5);
            Controls.Add(dtpSippingDate);
            Controls.Add(label3);
            Controls.Add(dtpRequireDate);
            Controls.Add(label2);
            Controls.Add(dtpOrderDate);
            Controls.Add(label1);
            Name = "FrmUpdateOrder";
            Text = "FrmUpdateOrder";
            Load += FrmUpdateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnSave;
        private ComboBox cbCustomer;
        private Label Customer;
        private TextBox txtStatus;
        private Label label4;
        private TextBox txtComment;
        private Label label5;
        private DateTimePicker dtpSippingDate;
        private Label label3;
        private DateTimePicker dtpRequireDate;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private Label label1;
        private ComboBox cbOrders;
        private Label label6;
    }
}