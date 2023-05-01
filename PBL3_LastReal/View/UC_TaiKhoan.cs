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
    public partial class UC_TaiKhoan : UserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
            GUI();
        }

        private void GUI()
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Accounts.Where(p => p.Type == 1).Select(p => new
                {
                    p.Username,
                    p.Money,
                    p.Person.Name
                }).ToList();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditAccount f = new fAddEditAccount(null);
            f.updateGUI += new fAddEditAccount.UpdateGUI(GUI);
            f.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string username = dgv.SelectedRows[0].Cells["Username"].Value.ToString();
                fAddEditAccount f = new fAddEditAccount(username);
                f.updateGUI += new fAddEditAccount.UpdateGUI(GUI);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không thể sửa quá nhiều tài khoản cùng lúc");
            }
        }

        private void btn_Password_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string username = dgv.SelectedRows[0].Cells["Username"].Value.ToString();
                fAdminPassword f = new fAdminPassword(username);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không thể sửa quá nhiều tài khoản cùng lúc");
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Accounts.
                    Where(p => p.Type == 1 && (p.Username.Contains(tb_search.Text) || p.Person.Name.Contains(tb_search.Text))).
                    Select(p => new
                    {
                        p.Username,
                        p.Money,
                        p.Person.Name
                    });
            }
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string username = dgv.SelectedRows[0].Cells["Username"].Value.ToString();
            int idPer = ManagePerson.Instance.getIDPersonByUsername(username);
            Person per = ManagePerson.Instance.GetPerson(idPer);
            tb_Name.Text = per.Name;
            tb_DOB.Text = per.DOB.Value.ToString("dd/MM/yyyy");
            tb_CCCD.Text = per.CCCD;
            tb_PhoneNum.Text = per.PhoneNum;
        }

        private void btn_Recharge_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string username = dgv.SelectedRows[0].Cells["Username"].Value.ToString();
                int idPer = ManagePerson.Instance.getIDPersonByUsername(username);
                string idAcc = ManageAccount.Instance.GetAccountByUsername(username).ID_Account;
                ManageHistory.Instance.delHistoryByID_Acc(idAcc);
                ManageAccount.Instance.delAccount(username);
                ManagePerson.Instance.delPerson(idPer);
                MessageBox.Show("Xóa tài khoản thành công");
                GUI();
            }
            else
            {
                MessageBox.Show("Số dòng được chọn để xóa không hợp lệ");
            }
        }
    }
}