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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            setCBB();
            dgv.DataSource = ManagePerson.Instance.getPersonsByType().Select(p => new { p.Person.Name, p.Person.CCCD, p.Person.PhoneNum }).ToArray();
        }
        private void setCBB()
        {
            cbb_type.Items.Add("Nhân viên");
            cbb_type.Items.Add("Thu ngân");
            cbb_type.Items.Add("Bảo vệ");
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditStaff f = new fAddEditStaff();
            f.UpdateDGV += new fAddEditStaff.UpdateDGVHandler(GUI);
            f.ShowDialog();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                cbb_type.Enabled = true;
                tb_name.Enabled = true;
                dt_dob.Enabled = true;
                tb_phone.Enabled = true;
                tb_salary.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chọn thông tin cần thay đổi!");
            }
        }
        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string cccd = dgv.SelectedRows[0].Cells["CCCD"].Value.ToString();
                Person per = ManagePerson.Instance.GetPersonByCCCD(cccd);
                Account acc = ManageAccount.Instance.getAccountByID_per(per.ID_Person);
                if (acc.Type == 2)
                {
                    cbb_type.Text = "Nhân viên";
                }
                else if (acc.Type == 3)
                {
                    cbb_type.Text = "Bảo vệ";
                }
                else if (acc.Type == 4)
                {
                    cbb_type.Text = "Thu ngân";
                }
                tb_name.Text = per.Name;
                dt_dob.Text = per.DOB.Value.ToString("dd/MM/yyyy");
                tb_CCCD.Text = per.CCCD.ToString();
                tb_phone.Text = per.PhoneNum.ToString();
                string id = per.ID_Person.ToString();
                Salary sar = ManageSalary.Instance.getSalaryByID(Convert.ToInt32(id));
                tb_salary.Text = sar.Salary1.ToString();
            }
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Accounts.Where(p => p.Type > 1 && p.Person.Name.Contains(tb_search.Text)).
                        Select(p => new { p.Person.Name, p.Person.DOB, p.Person.CCCD, p.Person.PhoneNum });
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    string cccd = row.Cells["CCCD"].Value.ToString();
                    ManagePerson.Instance.delPersonByCCCD(cccd);
                }
                MessageBox.Show("Xóa thông tin thành công!");
                GUI();
            }
            else
            {
                MessageBox.Show("Chọn dòng cần được xóa!");
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string CCCD = dgv.SelectedRows[0].Cells[1].Value.ToString();
            Person per = ManagePerson.Instance.GetPersonByCCCD(CCCD);
            string id = per.ID_Person.ToString();
            string type = cbb_type.Text;
            string name = tb_name.Text;
            string phone = tb_phone.Text;
            string cccd = tb_CCCD.Text;
            string dob = dt_dob.Text;
            string salary = tb_salary.Text;
            if (cbb_type.Text == "" || tb_name.Text == "" || tb_CCCD.Text == "" || dt_dob.Text == "" || tb_phone.Text == "" || tb_salary.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                ManageSalary.Instance.editSalaryAndPer(Convert.ToInt32(id), type, name, Convert.ToDateTime(dob), cccd, phone, Convert.ToInt32(salary));
                MessageBox.Show("Cập nhật thông tin thành công");
                cbb_type.Enabled = false;
                tb_name.Enabled = false;
                tb_CCCD.Enabled = false;
                dt_dob.Enabled = false;
                tb_phone.Enabled = false;
                tb_salary.Enabled = false;
                GUI();
            }
        }
    }
}
