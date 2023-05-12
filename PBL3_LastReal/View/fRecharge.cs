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
    }
}