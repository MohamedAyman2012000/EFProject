namespace MainProject.CreateForms
{
    partial class FrmCreatePayment
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
            Customer = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbCustomer = new ComboBox();
            txtDesc = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(330, 285);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 48;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.Location = new Point(64, 204);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 29);
            Customer.TabIndex = 45;
            Customer.Text = "Customer";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(169, 162);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(337, 29);
            txtAmount.TabIndex = 44;
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 162);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 43;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 63);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 41;
            label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(169, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(337, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(169, 204);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(337, 37);
            cbCustomer.TabIndex = 50;
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.None;
            txtDesc.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(170, 110);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(337, 29);
            txtDesc.TabIndex = 52;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 110);
            label3.Name = "label3";
            label3.Size = new Size(85, 29);
            label3.TabIndex = 51;
            label3.Text = "Description";
            // 
            // FrmCreatePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 388);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(cbCustomer);
            Controls.Add(dateTimePicker1);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(Customer);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCreatePayment";
            Text = "FrmCreatePayment";
            Load += FrmCreatePayment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnSave;
        private Label Customer;
        private TextBox txtAmount;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCustomer;
        private TextBox txtDesc;
        private Label label3;
    }
}