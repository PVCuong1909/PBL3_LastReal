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
            if(ManageAccount.Instance.checkLogIn(username, password))
            {
                int type = ManageAccount.Instance.getType(username);
                if(type == 0) 
                {
                    this.Hide();
                    fAdmin f = new fAdmin();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    int moneyRemain = ManageAccount.Instance.getMoneyRemain(username);
                    if(moneyRemain > 0)
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
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
            }    
            //QuanLyNetDataContext db = new QuanLyNetDataContext();
            //string TaiKhoan = tb_username.Text;
            //string MatKhau = QuanLyTaiKhoan.MD5Hash(tb_password.Text);
            //var query1 = db.Accounts.Where(p => p.Username == TaiKhoan && p.Password == MatKhau && p.Type != null).FirstOrDefault();
            //if (tb_username.Text == "" || tb_password.Text == "" || (tb_username.Text == "" && tb_password.Text == ""))
            //{
                
            //    MessageBox.Show("Vui lòng nhập tài khoản hoặc mât khẩu!");
                
            //}
            //else
            //{
            //    try
            //    {
            //        if (query1.Username == TaiKhoan && query1.Password == MatKhau)
            //        {
            //            if (query1.Type == 0)
            //            {
            //                this.Hide();
            //                fAdmin form = new fAdmin();
            //                form.ShowDialog();
            //                this.Close();
            //            }
            //            else
            //            {
            //                QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
            //                if (tk.CheckTienTaiKhoan((int)query1.Money) == true)
            //                {
            //                    this.Hide();
            //                    fChooseComputer fcc = new fChooseComputer();
            //                    fcc.ID_TaiKhoan += query1.ID_Account;
            //                    fcc.ShowDialog();
            //                    this.Close();
                                
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Tài khoản không đủ tiền!");
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            //    }
            //}    
        }
    }
}

