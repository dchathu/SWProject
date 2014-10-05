namespace Software
{
    partial class viewBestSprtRecords
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
            System.Windows.Forms.Label accountDiscriptionLabel;
            System.Windows.Forms.Label accountTypeLabel;
            System.Windows.Forms.Label initialBalanceLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            accountDiscriptionLabel = new System.Windows.Forms.Label();
            accountTypeLabel = new System.Windows.Forms.Label();
            initialBalanceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtOwner
            // 
            this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOwner.Location = new System.Drawing.Point(155, 126);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(163, 13);
            this.txtOwner.TabIndex = 2;
            // 
            // txtRecord
            // 
            this.txtRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecord.Location = new System.Drawing.Point(451, 124);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            this.txtRecord.Size = new System.Drawing.Size(163, 13);
            this.txtRecord.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Location = new System.Drawing.Point(451, 64);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(163, 13);
            this.txtYear.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtRecord);
            this.panel1.Controls.Add(this.txtOwner);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(accountDiscriptionLabel);
            this.panel1.Controls.Add(accountTypeLabel);
            this.panel1.Controls.Add(initialBalanceLabel);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 189);
            this.panel1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 18);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(5, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Best Records";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select Event";
            // 
            // accountDiscriptionLabel
            // 
            accountDiscriptionLabel.AutoSize = true;
            accountDiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountDiscriptionLabel.Location = new System.Drawing.Point(356, 59);
            accountDiscriptionLabel.Name = "accountDiscriptionLabel";
            accountDiscriptionLabel.Size = new System.Drawing.Size(51, 20);
            accountDiscriptionLabel.TabIndex = 8;
            accountDiscriptionLabel.Text = "Year :";
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountTypeLabel.Location = new System.Drawing.Point(17, 119);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new System.Drawing.Size(119, 20);
            accountTypeLabel.TabIndex = 4;
            accountTypeLabel.Text = "Record Owner :";
            // 
            // initialBalanceLabel
            // 
            initialBalanceLabel.AutoSize = true;
            initialBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            initialBalanceLabel.Location = new System.Drawing.Point(356, 119);
            initialBalanceLabel.Name = "initialBalanceLabel";
            initialBalanceLabel.Size = new System.Drawing.Size(69, 20);
            initialBalanceLabel.TabIndex = 6;
            initialBalanceLabel.Text = "Record :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(12, 229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(656, 52);
            this.panel7.TabIndex = 70;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.flowLayoutPanel2);
            this.panel8.Location = new System.Drawing.Point(504, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(139, 46);
            this.panel8.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(130, 46);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 42;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewBestSprtRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 290);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "viewBestSprtRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.viewBestSprtRecords_FormClosing);
            this.Load += new System.EventHandler(this.viewBestSprtRecords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
    }
}