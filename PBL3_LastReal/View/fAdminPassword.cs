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
    public partial class fAdminPassword : Form
    {
        string usernamef;
        public fAdminPassword(string username)
        {
            InitializeComponent();
            usernamef = username;
            GUI();
        }
        public void GUI() 
        {
            tb_Username.Text = usernamef;
            tb_Username.Enabled = false;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(tb_NewPass.Text == ""||tb_checkNewPassword.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                if (tb_NewPass.Text == tb_checkNewPassword.Text)
                {
                    ManageAccount.Instance.updateAccount(usernamef, tb_NewPass.Text, 0);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }    
            }    
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
