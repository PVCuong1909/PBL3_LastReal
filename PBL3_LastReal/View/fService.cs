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
    public partial class fService : Form
    {
        public delegate void UpdateSummaryHandler(string summary);
        public event UpdateSummaryHandler Summary;
        private int id_com;
        private DataTable dt_Bill;
        private static List<Service> services;
        public fService(int ID_Computer)
        {
            InitializeComponent();
            initListService();
            id_com = ID_Computer;
            services = new List<Service>();
            dt_Bill = new DataTable();
            dt_Bill.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Quantity", DataType = typeof(int)},
                new DataColumn{ColumnName = "Summary", DataType = typeof(int)},
            });
            dgv_SelectedMatHang.DataSource = dt_Bill;
        }
        private void initListService()
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
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
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
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
                DateTime timeOrder = DateTime.Now;
                foreach (Service item in services)
                {
                    money += item.Summary;
                }

                OrderService order = new OrderService()
                {
                    ID_Computer = id_com,
                    OrderTime = timeOrder,
                    Summary = money
                };
                ManageOrder.Instance.addOrder(order);

                int id_Order = ManageOrder.Instance.GetOrder(id_com, timeOrder).ID_Order;
                foreach (Service item in services)
                {
                    DetailOrder detail = new DetailOrder()
                    {
                        ID_Order = id_Order,
                        ID_Product = ManageService.Instance.GetProduct(item.Name).ID_Product,
                        Quantity = item.Quantity,
                    };
                    ManageOrder.Instance.addDetailOrder(detail);
                }

                if(Summary != null)
                {
                    Summary(money.ToString());
                }

                ManageBill.Instance.addBill(money, 0, timeOrder);
                MessageBox.Show("Order thành công");
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
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
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
