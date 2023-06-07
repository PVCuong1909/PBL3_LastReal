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
using PBL3_LastReal.DTO;

namespace PBL3_LastReal.View
{
    public partial class fAddEditService : Form
    {
        private string ProductNameform;
        public delegate void UpdateGUI();
        public event UpdateGUI updateGUI;
        public fAddEditService(string ProductName)
        {
            InitializeComponent();
            if (ProductName != null)
            {
                GUI(ProductName);
                ProductNameform = ProductName;
            }
            tb_Path.ReadOnly = true;

        }
        public void GUI(string name)
        {
            string ProductName = name;
            int Idsp = ManageService.Instance.GetProductIdByName(ProductName);
            Product product = ManageService.Instance.GetProduct(Idsp);
            tb_Path.Text = Idsp.ToString();
            tb_Path.ReadOnly = true;
            tb_TenSP.Text = ProductName;
            tb_SL.Text = product.Quantity.ToString();
            tb_GiaNhap.Text = product.Price.ImPrice.ToString();
            tb_GiaBan.Text = product.Price.ExPrice.ToString();
            //tb_Path.Text = product.Path.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(ProductNameform == null)
            {
                int GiaNhap =Convert.ToInt32(tb_GiaNhap.Text);
                int GiaBan =Convert.ToInt32(tb_GiaBan.Text);
                Product p = new Product()
                {
                    Name = tb_TenSP.Text,
                    Quantity = Convert.ToInt32(tb_SL.Text),
                    ID_Price = ManageService.Instance.GetIdPrice(GiaNhap, GiaBan),
                    //Path = tb_Path.Text
                };
                ManageService.Instance.addProduct(p);
                updateGUI();
                this.Close();
            }
            else
            {
                int id =Convert.ToInt32(tb_Path.Text);
                string name = tb_TenSP.Text;
                int GiaNhap = Convert.ToInt32(tb_GiaNhap.Text);
                int GiaBan = Convert.ToInt32(tb_GiaBan.Text);
                string SL = tb_SL.Text;
                int IdPrice = ManageService.Instance.GetIdPrice(GiaNhap,GiaBan);
                string path = tb_Path.Text;

                ManageService.Instance.UpdateSanPham(id.ToString(),name,SL,IdPrice.ToString(),path);
                updateGUI();
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

