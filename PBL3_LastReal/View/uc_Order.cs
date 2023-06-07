using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_LastReal.View
{
    public partial class uc_Order : UserControl
    {
        public int id_ord;
        public uc_Order(int id)
        {
            InitializeComponent();
            this.id_ord = id;
            GUI();
        }
        private void GUI()
        {
            OrderService ord = ManageOrder.Instance.GetOrder(id_ord);
            tb_Location.Text = "Máy " + ord.ID_Computer;
            tb_TimeOrder.Text = ord.OrderTime.Value.ToString("hh:mm:ss tt");
        }
        private void uc_Order_Click(object sender, EventArgs e)
        {
            if (this.Parent.Controls.ContainsKey("order_0"))
            {
                this.Parent.Controls["order_0"].BackColor = SystemColors.Control;
            }
            if (this.Parent.Controls.ContainsKey("order_1"))
            {
                this.Parent.Controls["order_1"].BackColor = SystemColors.Control;
            }
            if (this.Parent.Controls.ContainsKey("order_2"))
            {
                this.Parent.Controls["order_2"].BackColor = SystemColors.Control;
            }
            if (this.Parent.Controls.ContainsKey("order_3"))
            {
                this.Parent.Controls["order_3"].BackColor = SystemColors.Control;
            }

            this.BackColor = Color.Gray;
        }
    }
}
