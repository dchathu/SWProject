namespace Software
{
    partial class IncomeStats
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
            this.btnFilterInc = new System.Windows.Forms.Button();
            this.dtpEnInc = new System.Windows.Forms.DateTimePicker();
            this.dtpStInc = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvIncSum = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncSum)).BeginInit();
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
            this.panel2.Controls.Add(this.lblAcNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFilterInc);
            this.panel2.Controls.Add(this.dtpEnInc);
            this.panel2.Controls.Add(this.dtpStInc);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 537);
            this.panel2.TabIndex = 0;
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
            // btnFilterInc
            // 
            this.btnFilterInc.Location = new System.Drawing.Point(789, 22);
            this.btnFilterInc.Name = "btnFilterInc";
            this.btnFilterInc.Size = new System.Drawing.Size(65, 23);
            this.btnFilterInc.TabIndex = 11;
            this.btnFilterInc.Text = "Filter";
            this.btnFilterInc.UseVisualStyleBackColor = true;
            this.btnFilterInc.Click += new System.EventHandler(this.btnFilterInc_Click);
            // 
            // dtpEnInc
            // 
            this.dtpEnInc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnInc.Location = new System.Drawing.Point(688, 24);
            this.dtpEnInc.Name = "dtpEnInc";
            this.dtpEnInc.Size = new System.Drawing.Size(96, 20);
            this.dtpEnInc.TabIndex = 10;
            // 
            // dtpStInc
            // 
            this.dtpStInc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStInc.Location = new System.Drawing.Point(568, 24);
            this.dtpStInc.Name = "dtpStInc";
            this.dtpStInc.Size = new System.Drawing.Size(96, 20);
            this.dtpStInc.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(3, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(852, 253);
            this.panel5.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(844, 254);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // IncomeStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeStats";
            this.Text = "Income Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncomeStats_FormClosing);
            this.Load += new System.EventHandler(this.IncomeStats_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvIncSum;
        private System.Windows.Forms.Button btnFilterInc;
        private System.Windows.Forms.DateTimePicker dtpEnInc;
        private System.Windows.Forms.DateTimePicker dtpStInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAcNum;
    }
}