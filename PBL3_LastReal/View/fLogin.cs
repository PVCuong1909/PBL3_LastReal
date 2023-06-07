using PBL3_LastReal.BLL;
using PBL3_LastReal.View;
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

namespace PBL3_LastReal
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text, password = tb_Password.Text;
            if (ManageAccount.Instance.checkLogIn(username, password))
            {
                int type = ManageAccount.Instance.getType(username);
                if (type == 0)
                {
                    this.Hide();
                    fAdmin f = new fAdmin();
                    f.ShowDialog();
                    this.Show();
                }
                else if (type == 1)
                {
                    int moneyRemain = ManageAccount.Instance.getMoneyRemain(username);
                    if (moneyRemain > 0)
                    {
                        this.Hide();
                        string id_Account = ManageAccount.Instance.getID(username);
                        fChooseComputer f = new fChooseComputer(id_Account);
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã hết tiền");
                    }
                }
                else if(type == 2)
                {
                    this.Hide();
                    fStaff f = new fStaff(ManageAccount.Instance.GetAccountByUsername(username));
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

