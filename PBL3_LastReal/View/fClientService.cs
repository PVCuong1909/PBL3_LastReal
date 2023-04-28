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
using PBL3_LastReal.View;

namespace PBL3_LastReal.View
{
    public partial class fClientService : Form
    {

        public fClientService()
        {
            InitializeComponent();

            TaoMatHang();
        }


     


        public void InitDGV(QuanLyNetDataContext db)
        {

            var query = db.Products.Select(p => new { p.pics, p.Name, p.price });
            dgv_ListThucDon.DataSource = query;

            dgv_ListThucDon.CurrentCell = null;

        }
        public void Initdgv2()
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            var query = db.Products.Select(p => new { p.SLDaDat, p.pics, p.Name, p.price });
            dgv_SelectedMatHang.DataSource = query;
        }
        //public void InitDGV2()
        //{
        //    QuanLyNetDataContext db = new QuanLyNetDataContext();
        //    dgv_SelectedMatHang.DataSource =ManageService.Instance.UpdateSelectedItem(db);
        //    dgv_SelectedMatHang.CurrentCell = null;
        //}
        public void TaoMatHang()
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            InitDGV(db);
        }
        private void dgv_ListThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            //{
            //    if (dgv_ListThucDon.SelectedRows[0].Selected)
            //    {
            //        ManageService.Instance.UpdateSelectState(db, InitDGV, e.RowIndex);

            //        dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db);
            //        dgv_SelectedMatHang.CurrentCell = null;

            //    }

            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageService.Instance.Reset();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {

                ManageService.Instance.UpdateItemQuantity(db);
                //ManageService.Instance.AddBill(pos, query, db, txt_Username.Text, ammount);

                ManageService.Instance.Reset();
                dgv_SelectedMatHang.DataSource = null;
                MessageBox.Show("Dat Hang Thanh Cong");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                int index = dgv_ListThucDon.CurrentCell.RowIndex;
                ManageService.Instance.UpdateSelectState(db, InitDGV, index);
                dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db, index);
                dgv_SelectedMatHang.CurrentCell = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                int index = dgv_ListThucDon.CurrentCell.RowIndex;
                ManageService.Instance.RemoveSelectState(db, index);
                dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db, index);
            }

        }

        
    }
}
