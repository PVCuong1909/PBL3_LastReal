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
    public partial class fAddEditAccount : Form
    {
        private string usernameform;
        public delegate void UpdateGUI();
        public event UpdateGUI updateGUI;
        public fAddEditAccount(string usernamef)
        {
            InitializeComponent();
            if(usernamef != null)
            {
                GUI(usernamef);
                usernameform = usernamef;
            }
        }
        public void GUI(string usernamef)
        {
            Account acc = ManageAccount.Instance.GetAccountByUsername(usernamef);
            Person per = ManagePerson.Instance.GetPerson((int)acc.ID_Person);
            tb_Name.Text = per.Name;
            tb_DOB.Text = per.DOB.Value.ToString("dd/MM/yyyy");
            tb_CCCD.Text = per.CCCD;
            tb_PhoneNum.Text = per.PhoneNum;
            tb_Username.Text = usernamef;
            tb_Money.Text = acc.Money.ToString();
            tb_Username.Enabled = false;
            tb_Password.Enabled = false;
            tb_Money.Enabled = false;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(usernameform == null)
            {
                Person per = new Person
                {
                    Name = tb_Name.Text,
                    DOB = Convert.ToDateTime(tb_DOB.Text),
                    CCCD = tb_CCCD.Text,
                    PhoneNum = tb_PhoneNum.Text,
                    Type = 1
                };
                ManagePerson.Instance.addPerson(per);
                string id_acc = "client" + ManageAccount.Instance.getNextID_Acc("client").ToString();
                string username = tb_Username.Text;
                string password = tb_Password.Text;
                int type = 1;
                int money = Convert.ToInt32(tb_Money.Text);
                int id_per = ManagePerson.Instance.getIDPersonByCCCD(tb_CCCD.Text);
                ManageAccount.Instance.addAccount(id_acc, username, password, type, money, id_per);
                MessageBox.Show("Thêm tài khoản cho khách hàng thành công");
                updateGUI();
            }
            else
            {
                int id_per = ManagePerson.Instance.getIDPersonByUsername(usernameform);
                string name = tb_Name.Text;
                DateTime DOB = Convert.ToDateTime(tb_DOB.Text);
                string CCCD = tb_CCCD.Text;
                string phoneNum = tb_PhoneNum.Text; 
                ManagePerson.Instance.updatePerson(id_per, name, DOB, CCCD, phoneNum);
                MessageBox.Show("Cập nhật thông tin thành công");
            }    
            this.Close();
        }
    }
}
