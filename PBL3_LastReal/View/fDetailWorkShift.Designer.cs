namespace PBL3_LastReal.View
{
    partial class fDetailWorkShift
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.dtp_Begin = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_OK = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại ca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bắt đầu";
            // 
            // cbb_Type
            // 
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Location = new System.Drawing.Point(119, 28);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(162, 21);
            this.cbb_Type.TabIndex = 4;
            // 
            // dtp_Begin
            // 
            this.dtp_Begin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Begin.Location = new System.Drawing.Point(119, 60);
            this.dtp_Begin.Name = "dtp_Begin";
            this.dtp_Begin.ShowUpDown = true;
            this.dtp_Begin.Size = new System.Drawing.Size(162, 20);
            this.dtp_Begin.TabIndex = 5;
            this.dtp_Begin.Value = new System.DateTime(2023, 5, 6, 15, 39, 0, 0);
            // 
            // dtp_End
            // 
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_End.Location = new System.Drawing.Point(119, 94);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.ShowUpDown = true;
            this.dtp_End.Size = new System.Drawing.Size(162, 20);
            this.dtp_End.TabIndex = 6;
            this.dtp_End.Value = new System.DateTime(2023, 5, 6, 15, 39, 0, 0);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(162, 134);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(61, 28);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(244, 134);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(61, 28);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // fDetailWorkShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 177);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Begin);
            this.Controls.Add(this.cbb_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fDetailWorkShift";
            this.Text = "fDetailWorkShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Type;
        private System.Windows.Forms.DateTimePicker dtp_Begin;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_OK;
    }
}