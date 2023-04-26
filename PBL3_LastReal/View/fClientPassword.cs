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
    public partial class fClientPassword : Form
    {
        private string ID_TK;
        public fClientPassword(string id_Account)
        {
            InitializeComponent();
            ID_TK = id_Account;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string password = tb_password.Text;
            string newPassword = tb_newPassword.Text;
            string checkNewPassword = tb_checkNewPassword.Text;
            if(password == "" || newPassword == "" || checkNewPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if(ManageAccount.Instance.checkPassword(ID_TK,password) == true)
                {
                    if(newPassword == checkNewPassword)
                    {
                        ManageAccount.Instance.changePassword(ID_TK, checkNewPassword);
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp!");
                    }        
                }   
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác!");
                }
            }    
        }
    }
}
