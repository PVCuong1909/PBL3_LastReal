namespace PBL3_LastReal.View
{
    partial class uc_Order
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
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.tb_TimeOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Location
            // 
            this.tb_Location.Location = new System.Drawing.Point(124, 15);
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.ReadOnly = true;
            this.tb_Location.Size = new System.Drawing.Size(227, 20);
            this.tb_Location.TabIndex = 7;
            // 
            // tb_TimeOrder
            // 
            this.tb_TimeOrder.Location = new System.Drawing.Point(124, 50);
            this.tb_TimeOrder.Name = "tb_TimeOrder";
            this.tb_TimeOrder.ReadOnly = true;
            this.tb_TimeOrder.Size = new System.Drawing.Size(227, 20);
            this.tb_TimeOrder.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Thời điểm đặt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Vị trí";
            // 
            // uc_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tb_Location);
            this.Controls.Add(this.tb_TimeOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "uc_Order";
            this.Size = new System.Drawing.Size(362, 83);
            this.Click += new System.EventHandler(this.uc_Order_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.TextBox tb_TimeOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
