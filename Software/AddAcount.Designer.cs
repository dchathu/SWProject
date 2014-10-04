namespace Software
{
    partial class AddAcount
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
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label accountTypeLabel;
            System.Windows.Forms.Label initialBalanceLabel;
            System.Windows.Forms.Label accountDiscriptionLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdAcName = new System.Windows.Forms.TextBox();
            this.cmbAdAcType = new System.Windows.Forms.ComboBox();
            this.btnAddAc = new System.Windows.Forms.Button();
            this.txtAdAcNum = new System.Windows.Forms.TextBox();
            this.txtAdAcIniBal = new System.Windows.Forms.TextBox();
            this.txtAdAcDisc = new System.Windows.Forms.TextBox();
            this.btnResetFields = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            accountTypeLabel = new System.Windows.Forms.Label();
            initialBalanceLabel = new System.Windows.Forms.Label();
            accountDiscriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountNumberLabel.Location = new System.Drawing.Point(12, 78);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(113, 17);
            accountNumberLabel.TabIndex = 9;
            accountNumberLabel.Text = "Account Number";
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountTypeLabel.Location = new System.Drawing.Point(12, 123);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new System.Drawing.Size(95, 17);
            accountTypeLabel.TabIndex = 10;
            accountTypeLabel.Text = "Account Type";
            // 
            // initialBalanceLabel
            // 
            initialBalanceLabel.AutoSize = true;
            initialBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            initialBalanceLabel.Location = new System.Drawing.Point(12, 170);
            initialBalanceLabel.Name = "initialBalanceLabel";
            initialBalanceLabel.Size = new System.Drawing.Size(95, 17);
            initialBalanceLabel.TabIndex = 11;
            initialBalanceLabel.Text = "Initial Balance";
            // 
            // accountDiscriptionLabel
            // 
            accountDiscriptionLabel.AutoSize = true;
            accountDiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountDiscriptionLabel.Location = new System.Drawing.Point(12, 209);
            accountDiscriptionLabel.Name = "accountDiscriptionLabel";
            accountDiscriptionLabel.Size = new System.Drawing.Size(74, 17);
            accountDiscriptionLabel.TabIndex = 12;
            accountDiscriptionLabel.Text = "Discription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // txtAdAcName
            // 
            this.txtAdAcName.Location = new System.Drawing.Point(164, 27);
            this.txtAdAcName.Name = "txtAdAcName";
            this.txtAdAcName.Size = new System.Drawing.Size(176, 20);
            this.txtAdAcName.TabIndex = 1;
            // 
            // cmbAdAcType
            // 
            this.cmbAdAcType.FormattingEnabled = true;
            this.cmbAdAcType.Items.AddRange(new object[] {
            "Savings",
            "Checking",
            "Current"});
            this.cmbAdAcType.Location = new System.Drawing.Point(164, 123);
            this.cmbAdAcType.Name = "cmbAdAcType";
            this.cmbAdAcType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAdAcType.Size = new System.Drawing.Size(176, 21);
            this.cmbAdAcType.TabIndex = 2;
            this.cmbAdAcType.Text = "Select Account Type";
            // 
            // btnAddAc
            // 
            this.btnAddAc.Location = new System.Drawing.Point(103, 323);
            this.btnAddAc.Name = "btnAddAc";
            this.btnAddAc.Size = new System.Drawing.Size(75, 30);
            this.btnAddAc.TabIndex = 3;
            this.btnAddAc.Text = "Add";
            this.btnAddAc.UseVisualStyleBackColor = true;
            this.btnAddAc.Click += new System.EventHandler(this.btnAddAc_Click);
            // 
            // txtAdAcNum
            // 
            this.txtAdAcNum.Location = new System.Drawing.Point(164, 75);
            this.txtAdAcNum.Name = "txtAdAcNum";
            this.txtAdAcNum.Size = new System.Drawing.Size(176, 20);
            this.txtAdAcNum.TabIndex = 13;
            // 
            // txtAdAcIniBal
            // 
            this.txtAdAcIniBal.Location = new System.Drawing.Point(164, 167);
            this.txtAdAcIniBal.Name = "txtAdAcIniBal";
            this.txtAdAcIniBal.Size = new System.Drawing.Size(176, 20);
            this.txtAdAcIniBal.TabIndex = 14;
            // 
            // txtAdAcDisc
            // 
            this.txtAdAcDisc.Location = new System.Drawing.Point(164, 209);
            this.txtAdAcDisc.MaxLength = 145;
            this.txtAdAcDisc.Multiline = true;
            this.txtAdAcDisc.Name = "txtAdAcDisc";
            this.txtAdAcDisc.Size = new System.Drawing.Size(176, 101);
            this.txtAdAcDisc.TabIndex = 15;
            // 
            // btnResetFields
            // 
            this.btnResetFields.Location = new System.Drawing.Point(184, 323);
            this.btnResetFields.Name = "btnResetFields";
            this.btnResetFields.Size = new System.Drawing.Size(75, 30);
            this.btnResetFields.TabIndex = 16;
            this.btnResetFields.Text = "Reset";
            this.btnResetFields.UseVisualStyleBackColor = true;
            this.btnResetFields.Click += new System.EventHandler(this.btnResetFields_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(265, 323);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 30);
            this.btnCancelAdd.TabIndex = 17;
            this.btnCancelAdd.Text = "Close";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = ":";
            // 
            // AddAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 365);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnResetFields);
            this.Controls.Add(this.txtAdAcDisc);
            this.Controls.Add(this.txtAdAcIniBal);
            this.Controls.Add(this.txtAdAcNum);
            this.Controls.Add(accountNumberLabel);
            this.Controls.Add(accountTypeLabel);
            this.Controls.Add(initialBalanceLabel);
            this.Controls.Add(accountDiscriptionLabel);
            this.Controls.Add(this.btnAddAc);
            this.Controls.Add(this.cmbAdAcType);
            this.Controls.Add(this.txtAdAcName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAcount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAcount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAcount_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdAcName;
        private System.Windows.Forms.ComboBox cmbAdAcType;
        private System.Windows.Forms.Button btnAddAc;
        private System.Windows.Forms.TextBox txtAdAcNum;
        private System.Windows.Forms.TextBox txtAdAcIniBal;
        private System.Windows.Forms.TextBox txtAdAcDisc;
        private System.Windows.Forms.Button btnResetFields;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}