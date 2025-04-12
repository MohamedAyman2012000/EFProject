namespace MainProject.UpdateForms
{
    partial class FrmUpdateEmployee
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
            btnEdit = new Button();
            cbEmployee = new ComboBox();
            cbOffice = new ComboBox();
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
            cbMainEmp = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(488, 375);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 40;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(187, 375);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 46);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbEmployee
            // 
            cbEmployee.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(612, 181);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(196, 37);
            cbEmployee.TabIndex = 54;
           // cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // cbOffice
            // 
            cbOffice.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOffice.FormattingEnabled = true;
            cbOffice.Location = new Point(612, 121);
            cbOffice.Name = "cbOffice";
            cbOffice.Size = new Size(196, 37);
            cbOffice.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(518, 129);
            label7.Name = "label7";
            label7.Size = new Size(51, 29);
            label7.TabIndex = 52;
            label7.Text = "Office";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(518, 184);
            label6.Name = "label6";
            label6.Size = new Size(81, 29);
            label6.TabIndex = 51;
            label6.Text = "Reports To";
            // 
            // txtJobTitle
            // 
            txtJobTitle.BorderStyle = BorderStyle.None;
            txtJobTitle.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJobTitle.Location = new Point(122, 307);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(282, 29);
            txtJobTitle.TabIndex = 50;
            txtJobTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(32, 307);
            lbl.Name = "lbl";
            lbl.Size = new Size(63, 29);
            lbl.TabIndex = 49;
            lbl.Text = "Job Title";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(122, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 29);
            txtEmail.TabIndex = 48;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 261);
            label4.Name = "label4";
            label4.Size = new Size(48, 29);
            label4.TabIndex = 47;
            label4.Text = "Email";
            // 
            // txtExtension
            // 
            txtExtension.BorderStyle = BorderStyle.None;
            txtExtension.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExtension.Location = new Point(122, 217);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(282, 29);
            txtExtension.TabIndex = 46;
            txtExtension.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 217);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 45;
            label3.Text = "Extension";
            // 
            // txtLName
            // 
            txtLName.BorderStyle = BorderStyle.None;
            txtLName.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.Location = new Point(122, 175);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(282, 29);
            txtLName.TabIndex = 44;
            txtLName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 175);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 43;
            label2.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.BorderStyle = BorderStyle.None;
            txtFName.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.Location = new Point(122, 129);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(282, 29);
            txtFName.TabIndex = 42;
            txtFName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 129);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 41;
            label1.Text = "First Name";
            // 
            // cbMainEmp
            // 
            cbMainEmp.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMainEmp.FormattingEnabled = true;
            cbMainEmp.Location = new Point(350, 42);
            cbMainEmp.Name = "cbMainEmp";
            cbMainEmp.Size = new Size(231, 37);
            cbMainEmp.TabIndex = 56;
            cbMainEmp.SelectedIndexChanged += cbMainEmp_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 45);
            label5.Name = "label5";
            label5.Size = new Size(138, 29);
            label5.TabIndex = 55;
            label5.Text = "Select An Employee";
            // 
            // FrmUpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(cbMainEmp);
            Controls.Add(label5);
            Controls.Add(cbEmployee);
            Controls.Add(cbOffice);
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
            Controls.Add(btBack);
            Controls.Add(btnEdit);
            Name = "FrmUpdateEmployee";
            Text = "FrmUpdateEmployee";
            Load += FrmUpdateEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnEdit;
        private ComboBox cbEmployee;
        private ComboBox cbOffice;
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
        private ComboBox cbMainEmp;
        private Label label5;
    }
}