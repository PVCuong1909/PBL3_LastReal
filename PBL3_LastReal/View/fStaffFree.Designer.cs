namespace PBL3_LastReal.View
{
    partial class fStaffFree
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
            this.dgv_Staff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Free = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_OK = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Free)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff.Location = new System.Drawing.Point(446, 36);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.Size = new System.Drawing.Size(379, 237);
            this.dgv_Staff.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách nhân viên ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách nhân viên hiện có";
            // 
            // dgv_Free
            // 
            this.dgv_Free.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Free.Location = new System.Drawing.Point(12, 36);
            this.dgv_Free.Name = "dgv_Free";
            this.dgv_Free.Size = new System.Drawing.Size(379, 237);
            this.dgv_Free.TabIndex = 6;
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(579, 279);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 30);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa nhân viên";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(705, 279);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(120, 30);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(453, 279);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 30);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm nhân viên";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(327, 279);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 30);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // fStaffFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 316);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_Free);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Staff);
            this.Name = "fStaffFree";
            this.Text = "fStaffFree";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Free;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_OK;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
    }
}