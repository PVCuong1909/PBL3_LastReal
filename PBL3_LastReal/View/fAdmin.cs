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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            UC_TaiKhoan uc = new UC_TaiKhoan();
            addUserControl(uc);
        }
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            PanelControl.Controls.Clear();
            PanelControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            UC_TaiKhoan uc = new UC_TaiKhoan();
            addUserControl(uc);
        }

        private void btn_May_Click(object sender, EventArgs e)
        {
            UC_May uc = new UC_May();
            addUserControl(uc);
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            UC_DichVu uc = new UC_DichVu();
            addUserControl(uc);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            f.ShowDialog();
            this.Close();
        }
    }
}
