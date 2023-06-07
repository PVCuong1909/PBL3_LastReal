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
using System.Timers;

namespace PBL3_LastReal.View
{
    public partial class fClient : Form
    {
        System.Timers.Timer timer;
        int h, m, s;
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

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;

            timer.Start();

            GUI();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => 
            {
                s += 1;
                if(s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if(m == 60)
                {
                    m = 0;
                    h += 1;
                }
                tb_UseTime.Text = h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');
                tb_RemainTime.Text = Convert.ToDateTime(tb_RemainTime.Text).Subtract(DateTime.Parse("00:00:01")).ToString();
            }));
        }

        private void GUI()
        {
            lb_NameComputer.Text = "Máy " + id_Computer;
            tb_SumTime.Text = ManageComputer.Instance.getRemainTime(id_Computer, id_Account);
            tb_RemainTime.Text = ManageComputer.Instance.getRemainTime(id_Computer, id_Account);
            tb_TimeCost.Text = ManageComputer.Instance.getPrice(id_Computer).ToString() + "/h";
            tb_ServiceCost.Text = "0";
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

        private void btn_Mess_Click(object sender, EventArgs e)
        {

        }
        
        private void fClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            int cost = ManageComputer.Instance.getPrice(id_Computer);
            int sum = h * cost + m * cost / 60 + s * cost / 3600;
            ManageAccount.Instance.editMoneyRemain(id_Account, sum);
            Application.DoEvents();
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
