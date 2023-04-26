using PBL3_LastReal.BLL;
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
    public partial class fClient : Form
    {
        private int id_Computer;
        private string id_Account;
        private DateTime timeBegin;
        public fClient(int id_com, string id_acc, DateTime time)
        {
            InitializeComponent();
            Application.OpenForms["fChooseComputer"].Close();
            id_Computer = id_com;
            id_Account = id_acc;
            timeBegin = time;
            GUI();
        }
        private void GUI()
        {
            lb_NameComputer.Text = "Máy" + id_Computer;
            tb_RemainTime.Text = ManageComputer.Instance.getRemainTime(id_Computer, id_Account);
            tb_TimeCost.Text = ManageComputer.Instance.getPrice(id_Computer).ToString() + "/h";
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            ManageHistory.Instance.addHistory(id_Computer, id_Account, timeBegin, DateTime.Now);  
            ManageComputer.Instance.changeStateToFree(id_Computer);
            this.Close();
        }
        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            fClientPassword f = new fClientPassword(id_Account);
            f.ShowDialog();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            fClientService f = new fClientService();
            f.ShowDialog();
        }
    }
}
