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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3_LastReal.View
{
    public partial class fChooseComputer : Form
    {
        private string id_Account;
        public fChooseComputer(string id)
        {
            InitializeComponent();
            GetCBB();
            id_Account = id;
        }
        public void GetCBB()
        {
            cbb_ChooseComp.Items.AddRange(ManageComputer.Instance.getAllID().ToArray());
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(cbb_ChooseComp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn máy");
            }
            else
            {
                int id_com = Convert.ToInt32(cbb_ChooseComp.Text);
                int state = ManageComputer.Instance.getState(id_com);
                if(state == 0)
                {
                    this.Hide();
                    fClient f = new fClient(id_com, id_Account, DateTime.Now);
                    ManageComputer.Instance.changeStateToUsed(id_com);
                    f.ShowDialog();
                }
                else if(state == 1)
                {
                    MessageBox.Show("Máy đã có người dùng");
                }
                else
                {
                    MessageBox.Show("Máy hiện tại đang hỏng");
                }
            }
        }
    }
}
