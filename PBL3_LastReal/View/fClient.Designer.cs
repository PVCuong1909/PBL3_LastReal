namespace PBL3_LastReal.View
{
    partial class fClient
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
            this.pn_Title = new System.Windows.Forms.Panel();
            this.lb_NameComputer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.btn_Service = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Password = new System.Windows.Forms.Button();
            this.btn_Mess = new System.Windows.Forms.Button();
            this.tb_ServiceCost = new System.Windows.Forms.TextBox();
            this.tb_TimeCost = new System.Windows.Forms.TextBox();
            this.tb_RemainTime = new System.Windows.Forms.TextBox();
            this.tb_SumTime = new System.Windows.Forms.TextBox();
            this.tb_UseTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_Title.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Title
            // 
            this.pn_Title.BackColor = System.Drawing.Color.DimGray;
            this.pn_Title.Controls.Add(this.lb_NameComputer);
            this.pn_Title.Controls.Add(this.label1);
            this.pn_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Title.Location = new System.Drawing.Point(0, 0);
            this.pn_Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Title.Name = "pn_Title";
            this.pn_Title.Size = new System.Drawing.Size(381, 37);
            this.pn_Title.TabIndex = 0;
            // 
            // lb_NameComputer
            // 
            this.lb_NameComputer.AutoSize = true;
            this.lb_NameComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameComputer.ForeColor = System.Drawing.Color.White;
            this.lb_NameComputer.Location = new System.Drawing.Point(175, 9);
            this.lb_NameComputer.Name = "lb_NameComputer";
            this.lb_NameComputer.Size = new System.Drawing.Size(0, 20);
            this.lb_NameComputer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // pn_Main
            // 
            this.pn_Main.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.pn_Main.Controls.Add(this.btn_Service);
            this.pn_Main.Controls.Add(this.btn_LogOut);
            this.pn_Main.Controls.Add(this.btn_Password);
            this.pn_Main.Controls.Add(this.btn_Mess);
            this.pn_Main.Controls.Add(this.tb_ServiceCost);
            this.pn_Main.Controls.Add(this.tb_TimeCost);
            this.pn_Main.Controls.Add(this.tb_RemainTime);
            this.pn_Main.Controls.Add(this.tb_SumTime);
            this.pn_Main.Controls.Add(this.tb_UseTime);
            this.pn_Main.Controls.Add(this.label7);
            this.pn_Main.Controls.Add(this.label6);
            this.pn_Main.Controls.Add(this.label5);
            this.pn_Main.Controls.Add(this.label4);
            this.pn_Main.Controls.Add(this.label3);
            this.pn_Main.Location = new System.Drawing.Point(40, 62);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(301, 380);
            this.pn_Main.TabIndex = 1;
            // 
            // btn_Service
            // 
            this.btn_Service.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Service.ForeColor = System.Drawing.Color.White;
            this.btn_Service.Location = new System.Drawing.Point(172, 314);
            this.btn_Service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(80, 46);
            this.btn_Service.TabIndex = 14;
            this.btn_Service.Text = "Dịch vụ";
            this.btn_Service.UseVisualStyleBackColor = false;
            this.btn_Service.Click += new System.EventHandler(this.btn_DichVu_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.Location = new System.Drawing.Point(172, 258);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(80, 46);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Đăng xuất";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_Password
            // 
            this.btn_Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Password.ForeColor = System.Drawing.Color.White;
            this.btn_Password.Location = new System.Drawing.Point(45, 314);
            this.btn_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(80, 46);
            this.btn_Password.TabIndex = 12;
            this.btn_Password.Text = "Mật khẩu";
            this.btn_Password.UseVisualStyleBackColor = false;
            this.btn_Password.Click += new System.EventHandler(this.btn_MatKhau_Click);
            // 
            // btn_Mess
            // 
            this.btn_Mess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Mess.ForeColor = System.Drawing.Color.White;
            this.btn_Mess.Location = new System.Drawing.Point(45, 258);
            this.btn_Mess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Mess.Name = "btn_Mess";
            this.btn_Mess.Size = new System.Drawing.Size(80, 46);
            this.btn_Mess.TabIndex = 11;
            this.btn_Mess.Text = "Tin nhắn";
            this.btn_Mess.UseVisualStyleBackColor = false;
            // 
            // tb_ServiceCost
            // 
            this.tb_ServiceCost.Enabled = false;
            this.tb_ServiceCost.Location = new System.Drawing.Point(139, 226);
            this.tb_ServiceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ServiceCost.Name = "tb_ServiceCost";
            this.tb_ServiceCost.Size = new System.Drawing.Size(143, 22);
            this.tb_ServiceCost.TabIndex = 10;
            this.tb_ServiceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_TimeCost
            // 
            this.tb_TimeCost.Enabled = false;
            this.tb_TimeCost.Location = new System.Drawing.Point(139, 177);
            this.tb_TimeCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TimeCost.Name = "tb_TimeCost";
            this.tb_TimeCost.Size = new System.Drawing.Size(143, 22);
            this.tb_TimeCost.TabIndex = 9;
            this.tb_TimeCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_RemainTime
            // 
            this.tb_RemainTime.Enabled = false;
            this.tb_RemainTime.Location = new System.Drawing.Point(139, 127);
            this.tb_RemainTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RemainTime.Name = "tb_RemainTime";
            this.tb_RemainTime.Size = new System.Drawing.Size(143, 22);
            this.tb_RemainTime.TabIndex = 8;
            this.tb_RemainTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SumTime
            // 
            this.tb_SumTime.Enabled = false;
            this.tb_SumTime.Location = new System.Drawing.Point(139, 27);
            this.tb_SumTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SumTime.Name = "tb_SumTime";
            this.tb_SumTime.Size = new System.Drawing.Size(143, 22);
            this.tb_SumTime.TabIndex = 7;
            this.tb_SumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_UseTime
            // 
            this.tb_UseTime.Enabled = false;
            this.tb_UseTime.Location = new System.Drawing.Point(139, 78);
            this.tb_UseTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_UseTime.Name = "tb_UseTime";
            this.tb_UseTime.Size = new System.Drawing.Size(143, 22);
            this.tb_UseTime.TabIndex = 6;
            this.tb_UseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi phí dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thời gian còn lại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi phí thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thời gian";
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._13b17612f771282f7160;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 468);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.pn_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fClient";
            this.pn_Title.ResumeLayout(false);
            this.pn_Title.PerformLayout();
            this.pn_Main.ResumeLayout(false);
            this.pn_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Button btn_Service;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Password;
        private System.Windows.Forms.Button btn_Mess;
        private System.Windows.Forms.TextBox tb_ServiceCost;
        private System.Windows.Forms.TextBox tb_TimeCost;
        private System.Windows.Forms.TextBox tb_RemainTime;
        private System.Windows.Forms.TextBox tb_SumTime;
        private System.Windows.Forms.TextBox tb_UseTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_NameComputer;
    }
}