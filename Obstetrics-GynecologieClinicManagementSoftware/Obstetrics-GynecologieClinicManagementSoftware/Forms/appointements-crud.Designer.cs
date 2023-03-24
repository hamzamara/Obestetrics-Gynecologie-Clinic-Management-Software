namespace Obstetrics_GynecologieClinicManagementSoftware
{
    partial class appointements_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointements_crud));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personcombobx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timerangecombobx = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.ClosePctrBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.label7.Location = new System.Drawing.Point(50, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time Range :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.label5.Location = new System.Drawing.Point(135, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.label3.Location = new System.Drawing.Point(92, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "For Mrs. :";
            // 
            // personcombobx
            // 
            this.personcombobx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.personcombobx.FormattingEnabled = true;
            this.personcombobx.Location = new System.Drawing.Point(238, 45);
            this.personcombobx.Name = "personcombobx";
            this.personcombobx.Size = new System.Drawing.Size(435, 37);
            this.personcombobx.TabIndex = 13;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(238, 126);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(238, 37);
            this.dateTimePicker.TabIndex = 14;
            // 
            // timerangecombobx
            // 
            this.timerangecombobx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.timerangecombobx.FormattingEnabled = true;
            this.timerangecombobx.Items.AddRange(new object[] {
            "09:00-11:00",
            "11:00-13:00",
            "14:00-16:00",
            "16:00-18:00"});
            this.timerangecombobx.Location = new System.Drawing.Point(238, 195);
            this.timerangecombobx.Name = "timerangecombobx";
            this.timerangecombobx.Size = new System.Drawing.Size(435, 37);
            this.timerangecombobx.TabIndex = 15;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(149)))));
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.savebtn.Location = new System.Drawing.Point(774, 114);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(142, 52);
            this.savebtn.TabIndex = 16;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // ClosePctrBx
            // 
            this.ClosePctrBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(123)))));
            this.ClosePctrBx.Image = ((System.Drawing.Image)(resources.GetObject("ClosePctrBx.Image")));
            this.ClosePctrBx.Location = new System.Drawing.Point(985, -1);
            this.ClosePctrBx.Name = "ClosePctrBx";
            this.ClosePctrBx.Size = new System.Drawing.Size(35, 42);
            this.ClosePctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePctrBx.TabIndex = 17;
            this.ClosePctrBx.TabStop = false;
            this.ClosePctrBx.Click += new System.EventHandler(this.ClosePctrBx_Click);
            // 
            // appointements_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 273);
            this.Controls.Add(this.ClosePctrBx);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.timerangecombobx);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.personcombobx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "appointements_crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appointements_crud";
            ((System.ComponentModel.ISupportInitialize)(this.ClosePctrBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label3;
        private PictureBox ClosePctrBx;
        public ComboBox personcombobx;
        public DateTimePicker dateTimePicker;
        public ComboBox timerangecombobx;
        public Button savebtn;
    }
}