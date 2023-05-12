namespace PBL3_LastReal.View
{
    partial class fWorkShift
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Staff = new System.Windows.Forms.TabPage();
            this.flp_Staff = new System.Windows.Forms.FlowLayoutPanel();
            this.tp_Cashier = new System.Windows.Forms.TabPage();
            this.flp_Cashier = new System.Windows.Forms.FlowLayoutPanel();
            this.tp_Guard = new System.Windows.Forms.TabPage();
            this.flp_Guard = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DetailStaff = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1.SuspendLayout();
            this.tp_Staff.SuspendLayout();
            this.tp_Cashier.SuspendLayout();
            this.tp_Guard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Staff);
            this.tabControl1.Controls.Add(this.tp_Cashier);
            this.tabControl1.Controls.Add(this.tp_Guard);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 312);
            this.tabControl1.TabIndex = 12;
            // 
            // tp_Staff
            // 
            this.tp_Staff.Controls.Add(this.flp_Staff);
            this.tp_Staff.Location = new System.Drawing.Point(4, 22);
            this.tp_Staff.Name = "tp_Staff";
            this.tp_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Staff.Size = new System.Drawing.Size(384, 286);
            this.tp_Staff.TabIndex = 0;
            this.tp_Staff.Text = "Nhân viên";
            this.tp_Staff.UseVisualStyleBackColor = true;
            // 
            // flp_Staff
            // 
            this.flp_Staff.Location = new System.Drawing.Point(6, 6);
            this.flp_Staff.Name = "flp_Staff";
            this.flp_Staff.Size = new System.Drawing.Size(372, 274);
            this.flp_Staff.TabIndex = 0;
            // 
            // tp_Cashier
            // 
            this.tp_Cashier.Controls.Add(this.flp_Cashier);
            this.tp_Cashier.Location = new System.Drawing.Point(4, 22);
            this.tp_Cashier.Name = "tp_Cashier";
            this.tp_Cashier.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Cashier.Size = new System.Drawing.Size(384, 286);
            this.tp_Cashier.TabIndex = 1;
            this.tp_Cashier.Text = "Thu ngân";
            this.tp_Cashier.UseVisualStyleBackColor = true;
            // 
            // flp_Cashier
            // 
            this.flp_Cashier.Location = new System.Drawing.Point(3, 6);
            this.flp_Cashier.Name = "flp_Cashier";
            this.flp_Cashier.Size = new System.Drawing.Size(375, 274);
            this.flp_Cashier.TabIndex = 0;
            // 
            // tp_Guard
            // 
            this.tp_Guard.Controls.Add(this.flp_Guard);
            this.tp_Guard.Location = new System.Drawing.Point(4, 22);
            this.tp_Guard.Name = "tp_Guard";
            this.tp_Guard.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Guard.Size = new System.Drawing.Size(384, 286);
            this.tp_Guard.TabIndex = 2;
            this.tp_Guard.Text = "Bảo vệ";
            this.tp_Guard.UseVisualStyleBackColor = true;
            // 
            // flp_Guard
            // 
            this.flp_Guard.Location = new System.Drawing.Point(6, 6);
            this.flp_Guard.Name = "flp_Guard";
            this.flp_Guard.Size = new System.Drawing.Size(372, 274);
            this.flp_Guard.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(411, 65);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 25);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Thêm ca";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(675, 65);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 25);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Xóa ca";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(543, 65);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(126, 25);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Sửa thông tin ca";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(675, 34);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(126, 25);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // btn_DetailStaff
            // 
            this.btn_DetailStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DetailStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DetailStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DetailStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DetailStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DetailStaff.ForeColor = System.Drawing.Color.White;
            this.btn_DetailStaff.Location = new System.Drawing.Point(411, 34);
            this.btn_DetailStaff.Name = "btn_DetailStaff";
            this.btn_DetailStaff.Size = new System.Drawing.Size(258, 25);
            this.btn_DetailStaff.TabIndex = 21;
            this.btn_DetailStaff.Text = "Thông tin nhân viên ";
            this.btn_DetailStaff.Click += new System.EventHandler(this.btn_DetailStaff_Click);
            // 
            // fWorkShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 336);
            this.Controls.Add(this.btn_DetailStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tabControl1);
            this.Name = "fWorkShift";
            this.Text = "fWorkShift";
            this.tabControl1.ResumeLayout(false);
            this.tp_Staff.ResumeLayout(false);
            this.tp_Cashier.ResumeLayout(false);
            this.tp_Guard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Staff;
        private System.Windows.Forms.TabPage tp_Cashier;
        private System.Windows.Forms.TabPage tp_Guard;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private System.Windows.Forms.FlowLayoutPanel flp_Staff;
        private System.Windows.Forms.FlowLayoutPanel flp_Cashier;
        private System.Windows.Forms.FlowLayoutPanel flp_Guard;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_DetailStaff;
    }
}