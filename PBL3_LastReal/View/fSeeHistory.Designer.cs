namespace PBL3_LastReal.View
{
    partial class fSeeHistory
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_TaiK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_DOB = new System.Windows.Forms.TextBox();
            this.tb_PhoneNum = new System.Windows.Forms.TextBox();
            this.tb_CCCD = new System.Windows.Forms.TextBox();
            this.tb_Money = new System.Windows.Forms.TextBox();
            this.btn_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Danh sách lịch sử";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 55);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(336, 244);
            this.dgv.TabIndex = 20;
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thông tin khách hàng";
            // 
            // ID_TaiK
            // 
            this.ID_TaiK.AutoSize = true;
            this.ID_TaiK.BackColor = System.Drawing.Color.Transparent;
            this.ID_TaiK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TaiK.Location = new System.Drawing.Point(391, 206);
            this.ID_TaiK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_TaiK.Name = "ID_TaiK";
            this.ID_TaiK.Size = new System.Drawing.Size(45, 13);
            this.ID_TaiK.TabIndex = 32;
            this.ID_TaiK.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "CCCD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tên ĐN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(541, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tiền còn";
            // 
            // tb_Username
            // 
            this.tb_Username.Enabled = false;
            this.tb_Username.Location = new System.Drawing.Point(452, 102);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(84, 20);
            this.tb_Username.TabIndex = 38;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Location = new System.Drawing.Point(452, 203);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(84, 20);
            this.tb_Name.TabIndex = 39;
            // 
            // tb_DOB
            // 
            this.tb_DOB.Enabled = false;
            this.tb_DOB.Location = new System.Drawing.Point(452, 251);
            this.tb_DOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_DOB.Name = "tb_DOB";
            this.tb_DOB.Size = new System.Drawing.Size(84, 20);
            this.tb_DOB.TabIndex = 40;
            // 
            // tb_PhoneNum
            // 
            this.tb_PhoneNum.Enabled = false;
            this.tb_PhoneNum.Location = new System.Drawing.Point(581, 251);
            this.tb_PhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_PhoneNum.Name = "tb_PhoneNum";
            this.tb_PhoneNum.Size = new System.Drawing.Size(84, 20);
            this.tb_PhoneNum.TabIndex = 41;
            // 
            // tb_CCCD
            // 
            this.tb_CCCD.Enabled = false;
            this.tb_CCCD.Location = new System.Drawing.Point(581, 203);
            this.tb_CCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_CCCD.Name = "tb_CCCD";
            this.tb_CCCD.Size = new System.Drawing.Size(84, 20);
            this.tb_CCCD.TabIndex = 42;
            // 
            // tb_Money
            // 
            this.tb_Money.Enabled = false;
            this.tb_Money.Location = new System.Drawing.Point(596, 102);
            this.tb_Money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Money.Name = "tb_Money";
            this.tb_Money.Size = new System.Drawing.Size(84, 20);
            this.tb_Money.TabIndex = 43;
            // 
            // btn_Out
            // 
            this.btn_Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Out.ForeColor = System.Drawing.Color.White;
            this.btn_Out.Location = new System.Drawing.Point(493, 307);
            this.btn_Out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(84, 37);
            this.btn_Out.TabIndex = 44;
            this.btn_Out.Text = "Thoát";
            this.btn_Out.UseVisualStyleBackColor = false;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // fSeeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.tb_Money);
            this.Controls.Add(this.tb_CCCD);
            this.Controls.Add(this.tb_PhoneNum);
            this.Controls.Add(this.tb_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_TaiK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fSeeHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSeeHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID_TaiK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_DOB;
        private System.Windows.Forms.TextBox tb_PhoneNum;
        private System.Windows.Forms.TextBox tb_CCCD;
        private System.Windows.Forms.TextBox tb_Money;
        private System.Windows.Forms.Button btn_Out;
    }
}