namespace Software
{
    partial class Gallery
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
            this.albumsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // albumsDataGridView
            // 
            this.albumsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumsDataGridView.Location = new System.Drawing.Point(480, 128);
            this.albumsDataGridView.Name = "albumsDataGridView";
            this.albumsDataGridView.Size = new System.Drawing.Size(42, 75);
            this.albumsDataGridView.TabIndex = 2;
            this.albumsDataGridView.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 139);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.albumsDataGridView);
            this.Name = "Gallery";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Gallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView albumsDataGridView;
        private System.Windows.Forms.Button button1;
    }
}