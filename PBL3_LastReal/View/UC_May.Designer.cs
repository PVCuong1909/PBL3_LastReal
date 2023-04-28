namespace PBL3_LastReal.View
{
    partial class UC_May
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_SeeHistory = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_TaiK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_IDTK = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_using = new System.Windows.Forms.CheckBox();
            this.cb_free = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(11, 23);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(111, 22);
            this.tb_search.TabIndex = 15;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(349, 12);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 46);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 76);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(450, 279);
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thông tin máy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Máy số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Loại máy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng thái ";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(70, 388);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 46);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(270, 388);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 46);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_SeeHistory
            // 
            this.btn_SeeHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SeeHistory.ForeColor = System.Drawing.Color.White;
            this.btn_SeeHistory.Location = new System.Drawing.Point(670, 388);
            this.btn_SeeHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SeeHistory.Name = "btn_SeeHistory";
            this.btn_SeeHistory.Size = new System.Drawing.Size(112, 46);
            this.btn_SeeHistory.TabIndex = 25;
            this.btn_SeeHistory.Text = "Xem lịch sử";
            this.btn_SeeHistory.UseVisualStyleBackColor = false;
            this.btn_SeeHistory.Click += new System.EventHandler(this.btn_SeeHistory_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(470, 388);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 46);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(554, 73);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(111, 22);
            this.tb_id.TabIndex = 26;
            // 
            // tb_type
            // 
            this.tb_type.Enabled = false;
            this.tb_type.Location = new System.Drawing.Point(555, 116);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(111, 22);
            this.tb_type.TabIndex = 27;
            // 
            // tb_state
            // 
            this.tb_state.Enabled = false;
            this.tb_state.Location = new System.Drawing.Point(758, 116);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(111, 22);
            this.tb_state.TabIndex = 28;
            // 
            // tb_price
            // 
            this.tb_price.Enabled = false;
            this.tb_price.Location = new System.Drawing.Point(758, 73);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(111, 22);
            this.tb_price.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Thông tin đang sử dụng máy";
            // 
            // ID_TaiK
            // 
            this.ID_TaiK.AutoSize = true;
            this.ID_TaiK.BackColor = System.Drawing.Color.Transparent;
            this.ID_TaiK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TaiK.Location = new System.Drawing.Point(491, 240);
            this.ID_TaiK.Name = "ID_TaiK";
            this.ID_TaiK.Size = new System.Drawing.Size(49, 16);
            this.ID_TaiK.TabIndex = 31;
            this.ID_TaiK.Text = "ID_TK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên ĐN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(682, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tiền còn lại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(682, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Họ và tên";
            // 
            // tb_IDTK
            // 
            this.tb_IDTK.Enabled = false;
            this.tb_IDTK.Location = new System.Drawing.Point(555, 237);
            this.tb_IDTK.Name = "tb_IDTK";
            this.tb_IDTK.Size = new System.Drawing.Size(111, 22);
            this.tb_IDTK.TabIndex = 35;
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Location = new System.Drawing.Point(554, 284);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(111, 22);
            this.tb_username.TabIndex = 36;
            // 
            // tb_money
            // 
            this.tb_money.Enabled = false;
            this.tb_money.Location = new System.Drawing.Point(758, 237);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(111, 22);
            this.tb_money.TabIndex = 37;
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Location = new System.Drawing.Point(758, 284);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(111, 22);
            this.tb_name.TabIndex = 38;
            // 
            // cb_using
            // 
            this.cb_using.AutoSize = true;
            this.cb_using.BackColor = System.Drawing.Color.Transparent;
            this.cb_using.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_using.Location = new System.Drawing.Point(128, 26);
            this.cb_using.Name = "cb_using";
            this.cb_using.Size = new System.Drawing.Size(123, 20);
            this.cb_using.TabIndex = 39;
            this.cb_using.Text = "Đang sử dụng";
            this.cb_using.UseVisualStyleBackColor = false;
            // 
            // cb_free
            // 
            this.cb_free.AutoSize = true;
            this.cb_free.BackColor = System.Drawing.Color.Transparent;
            this.cb_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_free.Location = new System.Drawing.Point(246, 26);
            this.cb_free.Name = "cb_free";
            this.cb_free.Size = new System.Drawing.Size(97, 20);
            this.cb_free.TabIndex = 40;
            this.cb_free.Text = "Máy trống";
            this.cb_free.UseVisualStyleBackColor = false;
            // 
            // UC_May
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cb_free);
            this.Controls.Add(this.cb_using);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_IDTK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID_TaiK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_state);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_SeeHistory);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_search);
            this.Name = "UC_May";
            this.Size = new System.Drawing.Size(1160, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_SeeHistory;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID_TaiK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_IDTK;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.CheckBox cb_using;
        private System.Windows.Forms.CheckBox cb_free;
    }
}
