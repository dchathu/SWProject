namespace Software
{
    partial class AddCategories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategryType = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.btnCnclIncm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategryType);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 150);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 18);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Type :";
            // 
            // cmbCategryType
            // 
            this.cmbCategryType.FormattingEnabled = true;
            this.cmbCategryType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbCategryType.Location = new System.Drawing.Point(277, 100);
            this.cmbCategryType.Name = "cmbCategryType";
            this.cmbCategryType.Size = new System.Drawing.Size(245, 21);
            this.cmbCategryType.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(15, 101);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(245, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(349, 190);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(98, 23);
            this.btnAddIncome.TabIndex = 13;
            this.btnAddIncome.Text = "Add";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnCnclIncm
            // 
            this.btnCnclIncm.Location = new System.Drawing.Point(453, 190);
            this.btnCnclIncm.Name = "btnCnclIncm";
            this.btnCnclIncm.Size = new System.Drawing.Size(98, 23);
            this.btnCnclIncm.TabIndex = 12;
            this.btnCnclIncm.Text = "Close";
            this.btnCnclIncm.UseVisualStyleBackColor = true;
            this.btnCnclIncm.Click += new System.EventHandler(this.btnCnclIncm_Click);
            // 
            // AddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 236);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.btnCnclIncm);
            this.Controls.Add(this.panel1);
            this.Name = "AddCategories";
            this.Text = "AddCategories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategories_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategryType;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Button btnCnclIncm;
    }
}