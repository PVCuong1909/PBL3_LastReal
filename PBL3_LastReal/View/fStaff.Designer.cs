namespace PBL3_LastReal.View
{
    partial class fStaff
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ShowOrder = new Guna.UI2.WinForms.Guna2Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_Pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flp_Comp = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Pre = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Next = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_Logout);
            this.guna2Panel1.Controls.Add(this.btn_ChangePassword);
            this.guna2Panel1.Controls.Add(this.btn_ShowOrder);
            this.guna2Panel1.Controls.Add(this.tb_ID);
            this.guna2Panel1.Controls.Add(this.tb_Name);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.ptb_Pic);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(413, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(306, 66);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(101, 24);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePassword.Location = new System.Drawing.Point(199, 66);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(101, 24);
            this.btn_ChangePassword.TabIndex = 6;
            this.btn_ChangePassword.Text = "Đổi mật khẩu";
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_ShowOrder
            // 
            this.btn_ShowOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ShowOrder.ForeColor = System.Drawing.Color.White;
            this.btn_ShowOrder.Location = new System.Drawing.Point(92, 66);
            this.btn_ShowOrder.Name = "btn_ShowOrder";
            this.btn_ShowOrder.Size = new System.Drawing.Size(101, 24);
            this.btn_ShowOrder.TabIndex = 5;
            this.btn_ShowOrder.Text = "Xem đơn";
            this.btn_ShowOrder.Click += new System.EventHandler(this.btn_ShowOrder_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(182, 12);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(222, 20);
            this.tb_ID.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(182, 36);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(222, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // ptb_Pic
            // 
            this.ptb_Pic.ImageRotate = 0F;
            this.ptb_Pic.Location = new System.Drawing.Point(9, 10);
            this.ptb_Pic.Name = "ptb_Pic";
            this.ptb_Pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptb_Pic.Size = new System.Drawing.Size(77, 76);
            this.ptb_Pic.TabIndex = 0;
            this.ptb_Pic.TabStop = false;
            this.ptb_Pic.Click += new System.EventHandler(this.ptb_Pic_Click);
            // 
            // flp_Comp
            // 
            this.flp_Comp.Location = new System.Drawing.Point(3, 108);
            this.flp_Comp.Name = "flp_Comp";
            this.flp_Comp.Size = new System.Drawing.Size(413, 297);
            this.flp_Comp.TabIndex = 1;
            // 
            // btn_Pre
            // 
            this.btn_Pre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Pre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Pre.ForeColor = System.Drawing.Color.White;
            this.btn_Pre.Location = new System.Drawing.Point(95, 411);
            this.btn_Pre.Name = "btn_Pre";
            this.btn_Pre.Size = new System.Drawing.Size(84, 33);
            this.btn_Pre.TabIndex = 2;
            this.btn_Pre.Text = "Trước";
            this.btn_Pre.Click += new System.EventHandler(this.btn_Pre_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(240, 411);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(84, 33);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Sau";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Pre);
            this.Controls.Add(this.flp_Comp);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaff";
            this.Text = "fStaff";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_Comp;
        private Guna.UI2.WinForms.Guna2Button btn_Next;
        private Guna.UI2.WinForms.Guna2Button btn_Pre;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptb_Pic;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
        private Guna.UI2.WinForms.Guna2Button btn_ChangePassword;
        private Guna.UI2.WinForms.Guna2Button btn_ShowOrder;
    }
}