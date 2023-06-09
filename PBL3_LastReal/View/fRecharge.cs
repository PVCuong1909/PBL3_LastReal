using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace PBL3_LastReal.View
{
    public partial class fRecharge : Form
    {
        private string User;
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fRecharge(string user)
        {
            InitializeComponent();
            User = user;
            tb_user.Text = User;
            tb_money.Text = ManageAccount.Instance.GetAccountByUsername(User).Money.ToString();
            cbb_Computer.Text = "";
            cbb_Computer.Enabled = false;
        }
        public fRecharge() 
        {
            InitializeComponent();
            List<string> id = new List<string>();
            foreach (var item in ManageComputer.Instance.getAllComputer()) 
            {
                id.Add(item.ID_Computer.ToString());
            }
            cbb_Computer.Items.AddRange(id.ToArray());
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (tb_money.Enabled == false)
            {
                int newMoney = Convert.ToInt32(tb_newmoney.Text);
                ManageAccount.Instance.rechargeByUsername(User, newMoney);
                MessageBox.Show("Nạp tiền thành công!");
            }
            else
            {
                int Money = Convert.ToInt32(tb_money.Text);
                ManageAccount.Instance.editRechargeMoney(User, Money);
                MessageBox.Show("Cập nhật số tiền mới thành công!");
            }
            this.Dispose();
            UpdateDGV();
        }

        private void btn_EditMoney_Click(object sender, EventArgs e)
        {
            tb_money.Enabled = true;
            tb_newmoney.Enabled = false;
        }

        private void cbb_Computer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_com = Convert.ToInt32(cbb_Computer.SelectedItem);
            int state = ManageComputer.Instance.getState(id_com);
            if(state == 0)
            {
                MessageBox.Show("Máy trống");
            }
            else if(state == 2)
            {
                MessageBox.Show("Máy đang hỏng");
            }    
            else
            {
                Account acc = ManageAccount.Instance.GetAccountByID_Com(id_com);
                tb_user.Text = acc.Username;
                tb_money.Text = acc.Money.ToString();
            }
        }
    }
}