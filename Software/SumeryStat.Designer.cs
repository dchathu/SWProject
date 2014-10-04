namespace Software
{
    partial class MnthlyAnalyze
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
            this.lblAcNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterSum = new System.Windows.Forms.Button();
            this.dtpEnSum = new System.Windows.Forms.DateTimePicker();
            this.dtpStSum = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSum = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblAcNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFilterSum);
            this.panel2.Controls.Add(this.dtpEnSum);
            this.panel2.Controls.Add(this.dtpStSum);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 537);
            this.panel2.TabIndex = 1;
            // 
            // lblAcNum
            // 
            this.lblAcNum.AutoSize = true;
            this.lblAcNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcNum.Location = new System.Drawing.Point(145, 22);
            this.lblAcNum.Name = "lblAcNum";
            this.lblAcNum.Size = new System.Drawing.Size(0, 20);
            this.lblAcNum.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Account Number :";
            // 
            // btnFilterSum
            // 
            this.btnFilterSum.Location = new System.Drawing.Point(789, 22);
            this.btnFilterSum.Name = "btnFilterSum";
            this.btnFilterSum.Size = new System.Drawing.Size(65, 23);
            this.btnFilterSum.TabIndex = 11;
            this.btnFilterSum.Text = "Filter";
            this.btnFilterSum.UseVisualStyleBackColor = true;
            // 
            // dtpEnSum
            // 
            this.dtpEnSum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnSum.Location = new System.Drawing.Point(688, 24);
            this.dtpEnSum.Name = "dtpEnSum";
            this.dtpEnSum.Size = new System.Drawing.Size(96, 20);
            this.dtpEnSum.TabIndex = 10;
            // 
            // dtpStSum
            // 
            this.dtpStSum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStSum.Location = new System.Drawing.Point(568, 24);
            this.dtpStSum.Name = "dtpStSum";
            this.dtpStSum.Size = new System.Drawing.Size(96, 20);
            this.dtpStSum.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvSum);
            this.panel4.Location = new System.Drawing.Point(6, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 470);
            this.panel4.TabIndex = 1;
            // 
            // dgvSum
            // 
            this.dgvSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSum.BackgroundColor = System.Drawing.Color.White;
            this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSum.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSum.Location = new System.Drawing.Point(3, 4);
            this.dgvSum.Name = "dgvSum";
            this.dgvSum.ReadOnly = true;
            this.dgvSum.RowHeadersVisible = false;
            this.dgvSum.Size = new System.Drawing.Size(840, 461);
            this.dgvSum.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 18);
            this.panel3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monthly Summery";
            // 
            // MnthlyAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MnthlyAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Analyze";
            this.Load += new System.EventHandler(this.SumeryStat_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAcNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterSum;
        private System.Windows.Forms.DateTimePicker dtpEnSum;
        private System.Windows.Forms.DateTimePicker dtpStSum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}