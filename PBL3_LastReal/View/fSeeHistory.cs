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
    public partial class fSeeHistory : Form
    {
        private string ID_Com;
        public fSeeHistory(string id)
        {
            InitializeComponent();
            ID_Com = id;
            GUI();
        }
        private void GUI()
        {
            dgv.DataSource = ManageHistory.Instance.seeHistoryByIdCom(ID_Com).Select(p => new {p.ID_Account, p.TimeBegin, p.TimeEnd}).ToList();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Account acc = ManageHistory.Instance.getInformationAccHistory(id);
                tb_Username.Text = acc.Username;
                tb_Money.Text = acc.Money.ToString();
                Person per = ManageHistory.Instance.getInformationPerHistory(id);
                tb_Name.Text = per.Name;
                tb_DOB.Text = per.DOB;
                tb_CCCD.Text = per.CCCD;
                tb_PhoneNum.Text = per.PhoneNum;
            }
        }
    }
}
