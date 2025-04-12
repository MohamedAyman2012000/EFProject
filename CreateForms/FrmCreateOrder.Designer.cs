namespace MainProject.CreateForms
{
    partial class FrmCreateOrder
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
            dtpOrderDate = new DateTimePicker();
            label1 = new Label();
            dtpRequireDate = new DateTimePicker();
            label2 = new Label();
            dtpSippingDate = new DateTimePicker();
            label3 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            txtComment = new TextBox();
            label5 = new Label();
            cbCustomer = new ComboBox();
            Customer = new Label();
            btBack = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy-MM-dd";
            dtpOrderDate.Font = new Font("Cairo", 9F);
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(204, 105);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(337, 36);
            dtpOrderDate.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 105);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 50;
            label1.Text = "Order Date";
            // 
            // dtpRequireDate
            // 
            dtpRequireDate.CustomFormat = "yyyy-MM-dd";
            dtpRequireDate.Font = new Font("Cairo", 9F);
            dtpRequireDate.Format = DateTimePickerFormat.Custom;
            dtpRequireDate.Location = new Point(204, 165);
            dtpRequireDate.Name = "dtpRequireDate";
            dtpRequireDate.Size = new Size(337, 36);
            dtpRequireDate.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 165);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 52;
            label2.Text = "Require Date";
            // 
            // dtpSippingDate
            // 
            dtpSippingDate.CustomFormat = "yyyy-MM-dd";
            dtpSippingDate.Font = new Font("Cairo", 9F);
            dtpSippingDate.Format = DateTimePickerFormat.Custom;
            dtpSippingDate.Location = new Point(204, 222);
            dtpSippingDate.Name = "dtpSippingDate";
            dtpSippingDate.Size = new Size(337, 36);
            dtpSippingDate.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 228);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 54;
            label3.Text = "Shipping Date";
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(204, 281);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(337, 29);
            txtStatus.TabIndex = 59;
            txtStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 281);
            label4.Name = "label4";
            label4.Size = new Size(54, 29);
            label4.TabIndex = 58;
            label4.Text = "Status";
            // 
            // txtComment
            // 
            txtComment.BorderStyle = BorderStyle.None;
            txtComment.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(203, 333);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(337, 29);
            txtComment.TabIndex = 57;
            txtComment.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(98, 333);
            label5.Name = "label5";
            label5.Size = new Size(76, 29);
            label5.TabIndex = 56;
            label5.Text = "Comment";
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(204, 51);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(337, 37);
            cbCustomer.TabIndex = 61;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.Location = new Point(99, 51);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 29);
            Customer.TabIndex = 60;
            Customer.Text = "Customer";
            //Customer.Click += Customer_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(383, 400);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 63;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(183, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 62;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 499);
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
            Name = "FrmCreateOrder";
            Text = "FrmCreateOrder";
            Load += FrmCreateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpOrderDate;
        private Label label1;
        private DateTimePicker dtpRequireDate;
        private Label label2;
        private DateTimePicker dtpSippingDate;
        private Label label3;
        private TextBox txtStatus;
        private Label label4;
        private TextBox txtComment;
        private Label label5;
        private ComboBox cbCustomer;
        private Label Customer;
        private Button btBack;
        private Button btnSave;
    }
}