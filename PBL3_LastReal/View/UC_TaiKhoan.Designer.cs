namespace PBL3_LastReal.View
{
    partial class UC_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Password = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CCCD = new System.Windows.Forms.TextBox();
            this.tb_PhoneNum = new System.Windows.Forms.TextBox();
            this.tb_DOB = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Recharge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 64);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(428, 279);
            this.dgv.TabIndex = 1;
            this.dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseDoubleClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(275, 18);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(168, 28);
            this.tb_search.TabIndex = 16;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(65, 378);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 46);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Tạo tài khoản";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(210, 378);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 46);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "Cập nhật";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(352, 378);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(115, 46);
            this.btn_Del.TabIndex = 27;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Password
            // 
            this.btn_Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Password.ForeColor = System.Drawing.Color.White;
            this.btn_Password.Location = new System.Drawing.Point(494, 378);
            this.btn_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(115, 46);
            this.btn_Password.TabIndex = 28;
            this.btn_Password.Text = "Đổi mật khẩu";
            this.btn_Password.UseVisualStyleBackColor = false;
            this.btn_Password.Click += new System.EventHandler(this.btn_Password_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Căn cước công dân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Số điện thoại";
            // 
            // tb_CCCD
            // 
            this.tb_CCCD.Enabled = false;
            this.tb_CCCD.Location = new System.Drawing.Point(674, 214);
            this.tb_CCCD.Name = "tb_CCCD";
            this.tb_CCCD.Size = new System.Drawing.Size(168, 28);
            this.tb_CCCD.TabIndex = 34;
            // 
            // tb_PhoneNum
            // 
            this.tb_PhoneNum.Enabled = false;
            this.tb_PhoneNum.Location = new System.Drawing.Point(674, 276);
            this.tb_PhoneNum.Name = "tb_PhoneNum";
            this.tb_PhoneNum.Size = new System.Drawing.Size(168, 28);
            this.tb_PhoneNum.TabIndex = 35;
            // 
            // tb_DOB
            // 
            this.tb_DOB.Enabled = false;
            this.tb_DOB.Location = new System.Drawing.Point(674, 158);
            this.tb_DOB.Name = "tb_DOB";
            this.tb_DOB.Size = new System.Drawing.Size(168, 28);
            this.tb_DOB.TabIndex = 36;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Location = new System.Drawing.Point(674, 99);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(168, 28);
            this.tb_Name.TabIndex = 37;
            // 
            // btn_Recharge
            // 
            this.btn_Recharge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Recharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recharge.ForeColor = System.Drawing.Color.White;
            this.btn_Recharge.Location = new System.Drawing.Point(639, 378);
            this.btn_Recharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Recharge.Name = "btn_Recharge";
            this.btn_Recharge.Size = new System.Drawing.Size(115, 46);
            this.btn_Recharge.TabIndex = 38;
            this.btn_Recharge.Text = "Nạp tiền";
            this.btn_Recharge.UseVisualStyleBackColor = false;
            this.btn_Recharge.Click += new System.EventHandler(this.btn_Recharge_Click);
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Recharge);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_DOB);
            this.Controls.Add(this.tb_PhoneNum);
            this.Controls.Add(this.tb_CCCD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Password);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(880, 455);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_CCCD;
        private System.Windows.Forms.TextBox tb_PhoneNum;
        private System.Windows.Forms.TextBox tb_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Recharge;
    }
}
