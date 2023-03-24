namespace Obstetrics_GynecologieClinicManagementSoftware.Forms
{
    partial class show_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_history));
            this.recrd_grdview = new System.Windows.Forms.DataGridView();
            this.ClosePctrBx = new System.Windows.Forms.PictureBox();
            this.ttllbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recrd_grdview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // recrd_grdview
            // 
            this.recrd_grdview.AllowUserToAddRows = false;
            this.recrd_grdview.AllowUserToDeleteRows = false;
            this.recrd_grdview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.recrd_grdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recrd_grdview.Location = new System.Drawing.Point(0, 141);
            this.recrd_grdview.Name = "recrd_grdview";
            this.recrd_grdview.RowHeadersWidth = 62;
            this.recrd_grdview.RowTemplate.Height = 33;
            this.recrd_grdview.Size = new System.Drawing.Size(969, 584);
            this.recrd_grdview.TabIndex = 0;
            // 
            // ClosePctrBx
            // 
            this.ClosePctrBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.ClosePctrBx.Image = ((System.Drawing.Image)(resources.GetObject("ClosePctrBx.Image")));
            this.ClosePctrBx.Location = new System.Drawing.Point(934, -2);
            this.ClosePctrBx.Name = "ClosePctrBx";
            this.ClosePctrBx.Size = new System.Drawing.Size(35, 42);
            this.ClosePctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePctrBx.TabIndex = 18;
            this.ClosePctrBx.TabStop = false;
            this.ClosePctrBx.Click += new System.EventHandler(this.ClosePctrBx_Click);
            // 
            // ttllbl
            // 
            this.ttllbl.AutoSize = true;
            this.ttllbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ttllbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.ttllbl.Location = new System.Drawing.Point(26, 62);
            this.ttllbl.Name = "ttllbl";
            this.ttllbl.Size = new System.Drawing.Size(241, 40);
            this.ttllbl.TabIndex = 19;
            this.ttllbl.Text = " Visits History";
            // 
            // show_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 724);
            this.Controls.Add(this.ttllbl);
            this.Controls.Add(this.ClosePctrBx);
            this.Controls.Add(this.recrd_grdview);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "show_history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show_history";
            ((System.ComponentModel.ISupportInitialize)(this.recrd_grdview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePctrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox ClosePctrBx;
        private Label ttllbl;
        public DataGridView recrd_grdview;
    }
}