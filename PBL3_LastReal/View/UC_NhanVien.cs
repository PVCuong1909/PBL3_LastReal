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
            dgv.DataSource = ManagePerson.Instance.getPersonsByType().Select(p => new {p.ID_Person, p.Name, p.DOB, p.CCCD,p.PhoneNum}).ToArray();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddEditStaff f = new fAddEditStaff(null);
            f.UpdateDGV += new fAddEditStaff.UpdateDGVHandler(GUI);
            f.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count == 1)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Salary s = ManageSalary.Instance.getSalaryByID(Convert.ToInt32(id));
                fAddEditStaff f = new fAddEditStaff(s);
                f.UpdateDGV += new fAddEditStaff.UpdateDGVHandler(GUI);
                f.ShowDialog();
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Không thể cập nhật quá nhiều thông tin!");
            }
            else
            {
                MessageBox.Show("Chọn thông tin cần thay đổi!");
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv.SelectedRows.Count == 1)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Salary sar = ManageSalary.Instance.getSalaryByID(Convert.ToInt32(id));
                Person per = ManagePerson.Instance.GetPerson(Convert.ToInt32(id));
                tb_name.Text = per.Name;
                tb_dob.Text = per.DOB.ToString();
                tb_CCCD.Text = per.CCCD.ToString();
                tb_phone.Text = per.PhoneNum.ToString();
                tb_salary.Text = sar.Salary1.ToString();
            }    
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Persons.Where(p => p.Type == 2 && p.Name.Contains(tb_search.Text)).
                        Select(p => new { p.ID_Person, p.Name, p.DOB, p.CCCD, p.PhoneNum });
            }    
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString();
                    ManagePerson.Instance.delPerson(Convert.ToInt32(id));
                }
                MessageBox.Show("Xóa thông tin thành công!");
                GUI();
            }
            else
            {
                MessageBox.Show("CHọn dòng cần được xóa!");
            }
        }
    }
}
