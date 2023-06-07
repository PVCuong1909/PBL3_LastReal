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
    public partial class fDetailOrder : Form
    {
        int id_ord;
        public fDetailOrder(int id_ord)
        {
            InitializeComponent();
            this.id_ord = id_ord;
            GUI();
        }

        private void GUI()
        {
            List<DetailOrder> list = ManageOrder.Instance.getDetailOrder(id_ord);
            dgv.DataSource = list.Select(p => new 
            {
                p.Product.Name,
                p.Quantity,
                p.Product.Price.ExPrice
            }).ToList();

            tb_Summary.Text = ManageOrder.Instance.GetOrder(id_ord).Summary.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
