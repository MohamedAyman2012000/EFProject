namespace MainProject.CreateForms
{
    partial class FrmCreateEmployee
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
            label7 = new Label();
            label6 = new Label();
            txtJobTitle = new TextBox();
            lbl = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtExtension = new TextBox();
            label3 = new Label();
            txtLName = new TextBox();
            label2 = new Label();
            txtFName = new TextBox();
            label1 = new Label();
            cbOffice = new ComboBox();
            cbEmployee = new ComboBox();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(551, 330);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 38;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(551, 67);
            label7.Name = "label7";
            label7.Size = new Size(51, 29);
            label7.TabIndex = 33;
            label7.Text = "Office";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(551, 132);
            label6.Name = "label6";
            label6.Size = new Size(81, 29);
            label6.TabIndex = 31;
            label6.Text = "Reports To";
            // 
            // txtJobTitle
            // 
            txtJobTitle.BorderStyle = BorderStyle.None;
            txtJobTitle.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJobTitle.Location = new Point(155, 245);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(282, 29);
            txtJobTitle.TabIndex = 30;
            txtJobTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(65, 245);
            lbl.Name = "lbl";
            lbl.Size = new Size(63, 29);
            lbl.TabIndex = 29;
            lbl.Text = "Job Title";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(155, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 29);
            txtEmail.TabIndex = 28;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 199);
            label4.Name = "label4";
            label4.Size = new Size(48, 29);
            label4.TabIndex = 27;
            label4.Text = "Email";
            // 
            // txtExtension
            // 
            txtExtension.BorderStyle = BorderStyle.None;
            txtExtension.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExtension.Location = new Point(155, 155);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(282, 29);
            txtExtension.TabIndex = 26;
            txtExtension.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 155);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 25;
            label3.Text = "Extension";
            // 
            // txtLName
            // 
            txtLName.BorderStyle = BorderStyle.None;
            txtLName.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.Location = new Point(155, 113);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(282, 29);
            txtLName.TabIndex = 24;
            txtLName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 23;
            label2.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.BorderStyle = BorderStyle.None;
            txtFName.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.Location = new Point(155, 67);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(282, 29);
            txtFName.TabIndex = 22;
            txtFName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 67);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 21;
            label1.Text = "First Name";
            // 
            // cbOffice
            // 
            cbOffice.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOffice.FormattingEnabled = true;
            cbOffice.Location = new Point(645, 59);
            cbOffice.Name = "cbOffice";
            cbOffice.Size = new Size(196, 37);
            cbOffice.TabIndex = 39;
            // 
            // cbEmployee
            // 
            cbEmployee.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(645, 129);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(196, 37);
            cbEmployee.TabIndex = 40;
            // 
            // FrmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 437);
            Controls.Add(cbEmployee);
            Controls.Add(cbOffice);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtJobTitle);
            Controls.Add(lbl);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtExtension);
            Controls.Add(label3);
            Controls.Add(txtLName);
            Controls.Add(label2);
            Controls.Add(txtFName);
            Controls.Add(label1);
            Name = "FrmCreateEmployee";
            Text = "FrmCreateEmployee";
            Load += FrmCreateEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnSave;
        private Label label7;
        private Label label6;
        private TextBox txtJobTitle;
        private Label lbl;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtExtension;
        private Label label3;
        private TextBox txtLName;
        private Label label2;
        private TextBox txtFName;
        private Label label1;
        private ComboBox cbOffice;
        private ComboBox cbEmployee;
    }
}