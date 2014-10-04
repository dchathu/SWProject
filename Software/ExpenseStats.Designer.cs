namespace Software
{
    partial class ExpenseStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterExp = new System.Windows.Forms.Button();
            this.dtpEnExp = new System.Windows.Forms.DateTimePicker();
            this.dtpStExp = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chartExp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvIncSum = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExp)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncSum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAcNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFilterExp);
            this.panel2.Controls.Add(this.dtpEnExp);
            this.panel2.Controls.Add(this.dtpStExp);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
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
            // btnFilterExp
            // 
            this.btnFilterExp.Location = new System.Drawing.Point(789, 22);
            this.btnFilterExp.Name = "btnFilterExp";
            this.btnFilterExp.Size = new System.Drawing.Size(65, 23);
            this.btnFilterExp.TabIndex = 11;
            this.btnFilterExp.Text = "Filter";
            this.btnFilterExp.UseVisualStyleBackColor = true;
            this.btnFilterExp.Click += new System.EventHandler(this.btnFilterExp_Click);
            // 
            // dtpEnExp
            // 
            this.dtpEnExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnExp.Location = new System.Drawing.Point(688, 24);
            this.dtpEnExp.Name = "dtpEnExp";
            this.dtpEnExp.Size = new System.Drawing.Size(96, 20);
            this.dtpEnExp.TabIndex = 10;
            // 
            // dtpStExp
            // 
            this.dtpStExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStExp.Location = new System.Drawing.Point(568, 24);
            this.dtpStExp.Name = "dtpStExp";
            this.dtpStExp.Size = new System.Drawing.Size(96, 20);
            this.dtpStExp.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chartExp);
            this.panel5.Location = new System.Drawing.Point(3, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(852, 253);
            this.panel5.TabIndex = 2;
            // 
            // chartExp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartExp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExp.Legends.Add(legend1);
            this.chartExp.Location = new System.Drawing.Point(3, 3);
            this.chartExp.Name = "chartExp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExp.Series.Add(series1);
            this.chartExp.Size = new System.Drawing.Size(844, 254);
            this.chartExp.TabIndex = 0;
            this.chartExp.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvIncSum);
            this.panel4.Location = new System.Drawing.Point(3, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 225);
            this.panel4.TabIndex = 1;
            // 
            // dgvIncSum
            // 
            this.dgvIncSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncSum.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncSum.Location = new System.Drawing.Point(3, 4);
            this.dgvIncSum.Name = "dgvIncSum";
            this.dgvIncSum.ReadOnly = true;
            this.dgvIncSum.RowHeadersVisible = false;
            this.dgvIncSum.Size = new System.Drawing.Size(844, 216);
            this.dgvIncSum.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 18);
            this.panel3.TabIndex = 0;
            // 
            // ExpenseStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseStats";
            this.Text = "ExpenseStats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpenseStats_FormClosing);
            this.Load += new System.EventHandler(this.ExpenseStats_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartExp)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAcNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterExp;
        private System.Windows.Forms.DateTimePicker dtpEnExp;
        private System.Windows.Forms.DateTimePicker dtpStExp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvIncSum;
        private System.Windows.Forms.Panel panel3;
    }
}