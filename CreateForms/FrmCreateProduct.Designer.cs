namespace MainProject.CreateForms
{
    partial class FrmCreateProduct
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
            txtVendor = new TextBox();
            label3 = new Label();
            txtScale = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            lbl = new Label();
            txtQtyInStock = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBuyPrice = new TextBox();
            txtMSRP = new TextBox();
            cbProductLine = new ComboBox();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(562, 325);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 38;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(261, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtVendor
            // 
            txtVendor.BorderStyle = BorderStyle.None;
            txtVendor.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVendor.Location = new Point(138, 175);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(282, 29);
            txtVendor.TabIndex = 26;
            txtVendor.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 29);
            label3.TabIndex = 25;
            label3.Text = "Vendor";
            // 
            // txtScale
            // 
            txtScale.BorderStyle = BorderStyle.None;
            txtScale.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScale.Location = new Point(138, 133);
            txtScale.Name = "txtScale";
            txtScale.Size = new Size(282, 29);
            txtScale.TabIndex = 24;
            txtScale.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 133);
            label2.Name = "label2";
            label2.Size = new Size(47, 29);
            label2.TabIndex = 23;
            label2.Text = "Scale";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(138, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 29);
            txtName.TabIndex = 22;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 29);
            label1.TabIndex = 21;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 219);
            label4.Name = "label4";
            label4.Size = new Size(90, 29);
            label4.TabIndex = 27;
            label4.Text = "Descreption";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(138, 219);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 29);
            txtDescription.TabIndex = 28;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(492, 87);
            lbl.Name = "lbl";
            lbl.Size = new Size(86, 29);
            lbl.TabIndex = 29;
            lbl.Text = "Qty in stock";
            // 
            // txtQtyInStock
            // 
            txtQtyInStock.BorderStyle = BorderStyle.None;
            txtQtyInStock.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtyInStock.Location = new Point(582, 87);
            txtQtyInStock.Name = "txtQtyInStock";
            txtQtyInStock.Size = new Size(282, 29);
            txtQtyInStock.TabIndex = 30;
            txtQtyInStock.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(504, 130);
            label6.Name = "label6";
            label6.Size = new Size(72, 29);
            label6.TabIndex = 31;
            label6.Text = "Buy Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(513, 175);
            label7.Name = "label7";
            label7.Size = new Size(51, 29);
            label7.TabIndex = 33;
            label7.Text = "MsRP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(488, 219);
            label8.Name = "label8";
            label8.Size = new Size(89, 29);
            label8.TabIndex = 35;
            label8.Text = "ProductLine";
            // 
            // txtBuyPrice
            // 
            txtBuyPrice.BorderStyle = BorderStyle.None;
            txtBuyPrice.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuyPrice.Location = new Point(582, 130);
            txtBuyPrice.Name = "txtBuyPrice";
            txtBuyPrice.Size = new Size(282, 29);
            txtBuyPrice.TabIndex = 32;
            txtBuyPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMSRP
            // 
            txtMSRP.BorderStyle = BorderStyle.None;
            txtMSRP.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMSRP.Location = new Point(582, 175);
            txtMSRP.Name = "txtMSRP";
            txtMSRP.Size = new Size(282, 29);
            txtMSRP.TabIndex = 34;
            txtMSRP.TextAlign = HorizontalAlignment.Center;
            // 
            // cbProductLine
            // 
            cbProductLine.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProductLine.FormattingEnabled = true;
            cbProductLine.Location = new Point(582, 216);
            cbProductLine.Name = "cbProductLine";
            cbProductLine.Size = new Size(282, 37);
            cbProductLine.TabIndex = 41;
            // 
            // FrmCreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 450);
            Controls.Add(cbProductLine);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(txtMSRP);
            Controls.Add(label7);
            Controls.Add(txtBuyPrice);
            Controls.Add(label6);
            Controls.Add(txtQtyInStock);
            Controls.Add(lbl);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtVendor);
            Controls.Add(label3);
            Controls.Add(txtScale);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "FrmCreateProduct";
            Text = "FrmCreateProduct";
            Load += FrmCreateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnSave;
        private TextBox txtVendor;
        private Label label3;
        private TextBox txtScale;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Label label4;
        private TextBox txtDescription;
        private Label lbl;
        private TextBox txtQtyInStock;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtBuyPrice;
        private TextBox txtMSRP;
        private ComboBox cbProductLine;
    }
}