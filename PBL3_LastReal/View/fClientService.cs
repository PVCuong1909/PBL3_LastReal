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
using PBL3_LastReal.View;

namespace PBL3_LastReal.View
{
    public partial class fClientService : Form
    {
        public delegate void UpdateClientFormHandler(string summary);
        public event UpdateClientFormHandler UpdateClientForm;
        private DataTable dt_Bill;
        private static List<Service> services;
        public fClientService()
        {
            InitializeComponent();
            initListService();
            services = new List<Service>();
            dt_Bill = new DataTable();
            dt_Bill.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Quantity", DataType = typeof(int)},
                new DataColumn{ColumnName = "Summary", DataType = typeof(int)},
            });
            dgv_SelectedMatHang.DataSource = dt_Bill;
            //TaoMatHang();
        }
        private void initListService()
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv_ListThucDon.DataSource = db.Products.Select(p => new
                {
                    p.Name,
                    p.Price.ExPrice,
                    p.Quantity
                }).ToList();
            }
        }
        private void UpdateSummary()
        {
            int summary = 0;
            foreach (Service item in services)
            {
                summary += item.Summary;
            }
            txt_Summary.Text = summary.ToString();
        }
     


        //public void InitDGV(QuanLyNetDataContext db)
        //{
        //    //var query = db.Products.Select(p => new { p.pics, p.Name, p.price });
        //    //dgv_ListThucDon.DataSource = query;
        //    //dgv_ListThucDon.CurrentCell = null;
        //}
        //public void Initdgv2()
        //{
        //    //QuanLyNetDataContext db = new QuanLyNetDataContext();
        //    //var query = db.Products.Select(p => new { p.SLDaDat, p.pics, p.Name, p.price });
        //    //dgv_SelectedMatHang.DataSource = query;
        //}
        ////public void InitDGV2()
        ////{
        ////    QuanLyNetDataContext db = new QuanLyNetDataContext();
        ////    dgv_SelectedMatHang.DataSource =ManageService.Instance.UpdateSelectedItem(db);
        ////    dgv_SelectedMatHang.CurrentCell = null;
        ////}
        //public void TaoMatHang()
        //{
        //    QuanLyNetDataContext db = new QuanLyNetDataContext();
        //    InitDGV(db);
        //}
        //private void dgv_ListThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
        //    //{
        //    //    if (dgv_ListThucDon.SelectedRows[0].Selected)
        //    //    {
        //    //        ManageService.Instance.UpdateSelectState(db, InitDGV, e.RowIndex);

        //    //        dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db);
        //    //        dgv_SelectedMatHang.CurrentCell = null;

        //    //    }

        //    //}

        //}

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //ManageService.Instance.Reset();
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            //{

            //    //ManageService.Instance.UpdateItemQuantity(db);
            //    //ManageService.Instance.AddBill(pos, query, db, txt_Username.Text, ammount);

            //    //ManageService.Instance.Reset();
            //    dgv_SelectedMatHang.DataSource = null;
            //    MessageBox.Show("Dat Hang Thanh Cong");
            //}
            int checkQuantity = 0;
            string notEnoughService = "";
            foreach (Service item in services)
            {
                if(item.Quantity <= ManageService.Instance.getQuantity(item.Name))
                {
                    checkQuantity++;
                }
                else
                {
                    notEnoughService += item.Name + " ";
                }
            }
            if(checkQuantity == services.Count)
            {
                foreach (Service item in services)
                {
                    ManageService.Instance.UpdateDB(item.Name, item.Quantity);
                }
                int money = 0;
                foreach (Service item in services)
                {
                    money += item.Summary;
                }
                ManageBill.Instance.addBill(money, 0);
                MessageBox.Show("Order thành công");
                UpdateClientForm(money.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng "+ notEnoughService + " trong kho hiện không đủ");
            }
        }
        
        private void btn_Select_Click(object sender, EventArgs e)
        {
            if(dgv_ListThucDon.SelectedRows.Count == 1)
            {
                string nameProduct = dgv_ListThucDon.SelectedRows[0].Cells["Name"].Value.ToString();
                int price = Convert.ToInt32(dgv_ListThucDon.SelectedRows[0].Cells["ExPrice"].Value.ToString());
                int count = 0;
                if(services.Count > 0)
                {
                    foreach (Service s in services)
                    {
                        if (s.Name == nameProduct)
                        {
                            s.Quantity++;
                            s.Summary = s.Quantity * price;
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if (count == services.Count)
                    {
                        services.Add(new Service
                        {
                            Name = nameProduct,
                            Quantity = 1,
                            Summary = price
                        });
                    }
                }
                else
                {
                    services.Add(new Service
                    {
                        Name = nameProduct,
                        Quantity = 1,
                        Summary = price
                    });
                }
            }
            UpdateSummary();
            dgv_SelectedMatHang.DataSource = null;
            dgv_SelectedMatHang.DataSource = services;
            //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            //{
            //    int index = dgv_ListThucDon.CurrentCell.RowIndex;
            //    //ManageService.Instance.UpdateSelectState(db, InitDGV, index);
            //    //dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db, index);
            //    dgv_SelectedMatHang.CurrentCell = null;
            //}
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            //{
            //    int index = dgv_ListThucDon.CurrentCell.RowIndex;
            //    //ManageService.Instance.RemoveSelectState(db, index);
            //    //dgv_SelectedMatHang.DataSource = ManageService.Instance.UpdateSelectedItem(db, index);
            //}
            if(dgv_SelectedMatHang.SelectedRows.Count == 1)
            {
                int price = 0;
                string nameProduct = dgv_SelectedMatHang.SelectedRows[0].Cells["Name"].Value.ToString();
                foreach (DataGridViewRow row in dgv_ListThucDon.Rows)
                {
                    if (row.Cells["Name"].Value.ToString() == nameProduct)
                    {
                        price = Convert.ToInt32(row.Cells["ExPrice"].Value.ToString());
                        break;
                    }
                }
                foreach (Service item in services)
                {
                    if(item.Name == nameProduct)
                    {
                        item.Quantity--;
                        item.Summary -= price;
                        if(item.Quantity == 0)
                        {
                            services.Remove(item);
                        }
                        break;
                    }
                }
            }
            UpdateSummary();
            dgv_SelectedMatHang.DataSource = null;
            dgv_SelectedMatHang.DataSource = services;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgv_ListThucDon.DataSource = ManageService.Instance.GetProducts(txt_Search.Text);
        }
    }
}
