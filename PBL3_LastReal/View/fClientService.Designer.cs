namespace PBL3_LastReal.View
{
    partial class fClientService
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
            this.dgv_ListThucDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_SelectedMatHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Summary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListThucDon
            // 
            this.dgv_ListThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListThucDon.Location = new System.Drawing.Point(23, 54);
            this.dgv_ListThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ListThucDon.Name = "dgv_ListThucDon";
            this.dgv_ListThucDon.RowHeadersWidth = 51;
            this.dgv_ListThucDon.RowTemplate.Height = 24;
            this.dgv_ListThucDon.Size = new System.Drawing.Size(350, 276);
            this.dgv_ListThucDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // dgv_SelectedMatHang
            // 
            this.dgv_SelectedMatHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SelectedMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectedMatHang.Location = new System.Drawing.Point(439, 54);
            this.dgv_SelectedMatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_SelectedMatHang.Name = "dgv_SelectedMatHang";
            this.dgv_SelectedMatHang.RowHeadersWidth = 51;
            this.dgv_SelectedMatHang.RowTemplate.Height = 24;
            this.dgv_SelectedMatHang.Size = new System.Drawing.Size(266, 276);
            this.dgv_SelectedMatHang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH CHỌN";
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(23, 349);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(60, 37);
            this.btn_Select.TabIndex = 12;
            this.btn_Select.Text = "Chọn";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(106, 349);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(60, 37);
            this.btn_Del.TabIndex = 13;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(199, 349);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(60, 37);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(290, 349);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(60, 37);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(238, 23);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 20);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(496, 349);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 18);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Thành tiền";
            // 
            // txt_Summary
            // 
            this.txt_Summary.Location = new System.Drawing.Point(577, 347);
            this.txt_Summary.Name = "txt_Summary";
            this.txt_Summary.Size = new System.Drawing.Size(128, 20);
            this.txt_Summary.TabIndex = 18;
            // 
            // fClientService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 412);
            this.Controls.Add(this.txt_Summary);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_SelectedMatHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ListThucDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fClientService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fClientService";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectedMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListThucDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_SelectedMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TextBox txt_Summary;
    }
}