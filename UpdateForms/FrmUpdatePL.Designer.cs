namespace MainProject.UpdateForms
{
    partial class FrmUpdatePL
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
            txtImage = new TextBox();
            label3 = new Label();
            txtHTML = new TextBox();
            label2 = new Label();
            txtText = new TextBox();
            label1 = new Label();
            label4 = new Label();
            cbPL = new ComboBox();
            SuspendLayout();
            // 
            // btBack
            // 
            btBack.Location = new Point(338, 266);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 46);
            btBack.TabIndex = 48;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(138, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtImage
            // 
            txtImage.BorderStyle = BorderStyle.None;
            txtImage.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImage.Location = new Point(177, 185);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(337, 29);
            txtImage.TabIndex = 46;
            txtImage.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 185);
            label3.Name = "label3";
            label3.Size = new Size(54, 29);
            label3.TabIndex = 45;
            label3.Text = "Image";
            // 
            // txtHTML
            // 
            txtHTML.BorderStyle = BorderStyle.None;
            txtHTML.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHTML.Location = new Point(177, 143);
            txtHTML.Name = "txtHTML";
            txtHTML.Size = new Size(337, 29);
            txtHTML.TabIndex = 44;
            txtHTML.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 143);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 43;
            label2.Text = "Desc In HTML";
            // 
            // txtText
            // 
            txtText.BorderStyle = BorderStyle.None;
            txtText.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtText.Location = new Point(177, 97);
            txtText.Name = "txtText";
            txtText.Size = new Size(337, 29);
            txtText.TabIndex = 42;
            txtText.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 97);
            label1.Name = "label1";
            label1.Size = new Size(90, 29);
            label1.TabIndex = 41;
            label1.Text = "Desc In Text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 35);
            label4.Name = "label4";
            label4.Size = new Size(131, 29);
            label4.TabIndex = 49;
            label4.Text = "Select ProductLine";
            // 
            // cbPL
            // 
            cbPL.Font = new Font("Cairo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPL.FormattingEnabled = true;
            cbPL.Location = new Point(177, 32);
            cbPL.Name = "cbPL";
            cbPL.Size = new Size(337, 37);
            cbPL.TabIndex = 57;
            cbPL.SelectedIndexChanged += cbPL_SelectedIndexChanged;
            // 
            // FrmUpdatePL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 340);
            Controls.Add(cbPL);
            Controls.Add(label4);
            Controls.Add(btBack);
            Controls.Add(btnSave);
            Controls.Add(txtImage);
            Controls.Add(label3);
            Controls.Add(txtHTML);
            Controls.Add(label2);
            Controls.Add(txtText);
            Controls.Add(label1);
            Name = "FrmUpdatePL";
            Text = "FrmUpdatePL";
            Load += FrmUpdatePL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBack;
        private Button btnSave;
        private TextBox txtImage;
        private Label label3;
        private TextBox txtHTML;
        private Label label2;
        private TextBox txtText;
        private Label label1;
        private Label label4;
        private ComboBox cbPL;
    }
}