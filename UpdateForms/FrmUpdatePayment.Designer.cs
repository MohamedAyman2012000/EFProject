namespace MainProject.UpdateForms
{
    partial class FrmUpdatePayment
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
            cbCustomer = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btBack = new Button();
            btnSave = new Button();
            Customer = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbPayments = new ComboBox();
            label3 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(160, 227);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(337, 37);
            cbCustomer.TabIndex = 58;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(160, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 27);
            dateTimePicker1.TabIndex = 57;
            // 
            // btBack
            // 
            btBack.Location = new Point(321, 308);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 56;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(121, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 55;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.Location = new Point(55, 227);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 29);
            Customer.TabIndex = 54;
            Customer.Text = "Customer";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(160, 185);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(337, 29);
            txtAmount.TabIndex = 53;
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 185);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 52;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 93);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 51;
            label1.Text = "Date";
            // 
            // cbPayments
            // 
            cbPayments.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPayments.FormattingEnabled = true;
            cbPayments.Location = new Point(174, 21);
            cbPayments.Name = "cbPayments";
            cbPayments.Size = new Size(337, 37);
            cbPayments.TabIndex = 60;
            cbPayments.SelectedIndexChanged += cbPayments_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 26);
            label3.Name = "label3";
            label3.Size = new Size(113, 29);
            label3.TabIndex = 59;
            label3.Text = "Select Payment";
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.None;
            txtDesc.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(160, 136);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(337, 29);
            txtDesc.TabIndex = 62;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 136);
            label4.Name = "label4";
            label4.Size = new Size(85, 29);
            label4.TabIndex = 61;
            label4.Text = "Description";
            // 
            // FrmUpdatePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 404);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(cbPayments);
            Controls.Add(label3);
            Controls.Add(cbCustomer);
            Controls.Add(dateTimePicker1);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(Customer);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUpdatePayment";
            Text = "FrmUpdatePayment";
            Load += FrmUpdatePayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCustomer;
        private DateTimePicker dateTimePicker1;
        private Button btBack;
        private Button btnSave;
        private Label Customer;
        private TextBox txtAmount;
        private Label label2;
        private Label label1;
        private ComboBox cbPayments;
        private Label label3;
        private TextBox txtDesc;
        private Label label4;
    }
}