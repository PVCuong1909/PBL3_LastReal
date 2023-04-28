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
                tb_Username.Text = ManageHistory.Instance.getInformationAccHistory(id).Username;
                tb_Money.Text = ManageHistory.Instance.getInformationAccHistory(id).Money.ToString();
                tb_Name.Text = ManageHistory.Instance.getInformationPerHistory(id).Name;
                tb_DOB.Text = ManageHistory.Instance.getInformationPerHistory(id).DOB;
                tb_CCCD.Text = ManageHistory.Instance.getInformationPerHistory(id).CCCD;
                tb_PhoneNum.Text = ManageHistory.Instance.getInformationPerHistory(id).PhoneNum;
            }
        }
    }
}
