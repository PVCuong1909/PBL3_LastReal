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
    public partial class fOrder : Form
    {
        uc_Order uc;
        List<OrderService> orders = ManageOrder.Instance.getAllOrder();
        int first, end;
        public fOrder()
        {
            InitializeComponent();
            if(orders.Count > 0)
            {
                first = 0;
                if(orders.Count > 4) 
                {
                    end = 4;
                }
                else
                {
                    end = orders.Count;
                }
                GUI();
            }
        }
        private void create(int pos, int name)
        {
            uc_Order uc = new uc_Order(pos);
            uc.Name = "order_" + name;
            this.flp_Main.Controls.Add(uc);
        }
        private void GUI()
        {
            if (flp_Main.Controls.Count > 0) flp_Main.Controls.Clear();
            int count = 0;
            for(int i = first; i < end; i++) 
            {
                create(orders[i].ID_Order, count);
                count++;
            }
        }
        private void selectComponent()
        {
            foreach (Control item in flp_Main.Controls)
            {
                if (item.BackColor == Color.Gray)
                {
                    uc = (uc_Order)item;
                    break;
                }
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            selectComponent();

            OrderService ord = ManageOrder.Instance.GetOrder(uc.id_ord);

            List<DetailOrder> listDel = ManageOrder.Instance.getDetailOrder(uc.id_ord);

            foreach (var item in listDel)
            {
                ManageOrder.Instance.removeDetailOrder(item);
            }

            ManageBill.Instance.removeBill((DateTime)ord.OrderTime);

            ManageOrder.Instance.removeOrder(ord);

            MessageBox.Show("Xóa đơn thành công");

            orders = ManageOrder.Instance.getAllOrder();

            flp_Main.Controls.Clear();

            if (orders.Count > 0)
            {
                first = 0;
                if (orders.Count > 4)
                {
                    end = 4;
                }
                else
                {
                    end = orders.Count;
                }
                GUI();
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            selectComponent();

            fDetailOrder f = new fDetailOrder(uc.id_ord);
            f.ShowDialog();
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if(orders.Count > 4 && end + 1 <= orders.Count)
            {
                first++;
                end++;
                GUI();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            selectComponent();

            OrderService ord = ManageOrder.Instance.GetOrder(uc.id_ord);

            List<DetailOrder> listDel = ManageOrder.Instance.getDetailOrder(uc.id_ord);

            foreach (var item in listDel)
            {
                ManageOrder.Instance.removeDetailOrder(item);
            }

            ManageOrder.Instance.removeOrder(ord);

            MessageBox.Show("Giao đơn thành công");

            orders = ManageOrder.Instance.getAllOrder();

            flp_Main.Controls.Clear();

            if (orders.Count > 0)
            {
                first = 0;
                if (orders.Count > 4)
                {
                    end = 4;
                }
                else
                {
                    end = orders.Count;
                }
                GUI();
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            if(orders.Count > 4 && first - 1 >= 0)
            {
                first--;
                end--;
                GUI();
            }
        }
    }
}
