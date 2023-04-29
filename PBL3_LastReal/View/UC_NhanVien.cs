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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditStaff f = new fAddEditStaff();
            f.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            fAddEditStaff f = new fAddEditStaff();
            f.ShowDialog();
        }
    }
}
