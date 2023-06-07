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
using PBL3_LastReal.DTO;


namespace PBL3_LastReal.View
{
    public partial class fClient : Form
    {
        private int id_Computer;
        private string id_Account;
        private DateTime timeBegin;
        private History _history = new History();
        public fClient(int id_com, string id_acc, DateTime time)
        {
            InitializeComponent();
            Application.OpenForms["fChooseComputer"].Close();
            id_Computer = id_com;
            id_Account = id_acc;
            timeBegin = time;
            _history.ID_Computer = id_Computer;
            _history.ID_Account = id_Account;
            _history.TimeBegin = timeBegin;

            GUI();
        }
        private void GUI()
        {
            lb_NameComputer.Text = "Máy" + id_Computer;
            tb_RemainTime.Text = ManageComputer.Instance.getRemainTime(id_Computer, id_Account);
            tb_TimeCost.Text = ManageComputer.Instance.getPrice(id_Computer).ToString() + "/h";
        }
        private void setSummary(string summary)
        {
            tb_ServiceCost.Text = summary;
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            ManageHistory.Instance.addHistoryClickLogOut(id_Computer, id_Account, timeBegin);
            ManageComputer.Instance.changeStateToFree(id_Computer);
            this.Close();
        }
        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            fPassword f = new fPassword(id_Account);
            f.ShowDialog();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            fService f = new fService(id_Computer);
            f.Summary += new fService.UpdateSummaryHandler(setSummary);
            f.ShowDialog();
        }
    }
}
