using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_LastReal.BLL;
namespace PBL3_LastReal.View
{
    public partial class UC_DichVu : UserControl
    {
        public UC_DichVu()
        {
            InitializeComponent();
            GUI();
        }

        private void GUI()
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Products.Select(p => new
                {
                    p.pics,
                    p.Name,
                    p.Quantity,
                    p.Price.ImPrice,
                    p.Price.ExPrice
                }).ToList();
            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                string ProductName = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
                int Idsp = ManageService.Instance.GetProductIdByName(ProductName);
                Product product = ManageService.Instance.GetProduct(Idsp);
                tb_MaSP.Text = Idsp.ToString();
                tb_TenSP.Text = ProductName;
                tb_SLSP.Text = product.Quantity.ToString();
                tb_GiaNhap.Text = product.Price.ImPrice.ToString();
                tb_GiaBan.Text = product.Price.ExPrice.ToString();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            fAddEditService f = new fAddEditService(null);
            f.updateGUI += new fAddEditService.UpdateGUI(GUI);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count == 1 )
            {
                string ProductName = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
                fAddEditService f = new fAddEditService(ProductName);
                f.updateGUI += new fAddEditService.UpdateGUI(GUI);
                f.ShowDialog();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ProductName = dgv.SelectedRows[0].Cells["Name"].Value.ToString();
            int id = ManageService.Instance.GetProductIdByName(ProductName);
            ManageService.Instance.DeleteProduct(id);
            MessageBox.Show("Xoa Thanh Cong");
            GUI();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ManageService.Instance.SearchProduct(textBox1.Text);
        }
    }
}
