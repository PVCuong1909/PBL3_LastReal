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
            dgv.DataSource = ManagePerson.Instance.getPersonsByType().Select(p => new {p.Name, p.CCCD,p.PhoneNum}).ToArray();

        }
        private void setCBB()
        {
            cbb_type.Items.Add("Nhân viên");
            cbb_type.Items.Add("Thu ngân");
            cbb_type.Items.Add("Bảo vệ");
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
                string cccd = dgv.SelectedRows[0].Cells[1].Value.ToString();
                Person per = ManagePerson.Instance.GetPersonByCCCD(cccd);
                fAddEditStaff f = new fAddEditStaff(per);               
                f.UpdateDGV += new fAddEditStaff.UpdateDGVHandler(GUI);
                f.ShowDialog();
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được thay đổi thông tin một nhân viên!");
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
                string cccd = dgv.SelectedRows[0].Cells[1].Value.ToString();
                Person per = ManagePerson.Instance.GetPersonByCCCD(cccd);
                if (per.Type == 2)
                {
                    cbb_type.Text = "Nhân viên";
                }
                else if (per.Type == 4)
                {
                    cbb_type.Text = "Bảo vệ";
                }
                else if (per.Type == 3)
                {
                    cbb_type.Text = "Thu ngân";
                }   
                tb_name.Text = per.Name;
                dt_dob.Text = per.DOB.Value.ToString("yyyy/MM/dd");
                tb_CCCD.Text = per.CCCD.ToString();
                tb_phone.Text = per.PhoneNum.ToString();
                tb_work.Text = per.Works.ToString();
                string id = per.ID_Person.ToString();
                Salary sar = ManageSalary.Instance.getSalaryByID(Convert.ToInt32(id));
                tb_salary.Text = sar.Salary1.ToString();
            }    
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                dgv.DataSource = db.Persons.Where(p => p.Type > 1 && p.Name.Contains(tb_search.Text)).
                        Select(p => new { p.Name, p.DOB, p.CCCD, p.PhoneNum });
            }    
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0) 
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    string cccd = row.Cells[1].Value.ToString();
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

        private void btn_paySal_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                string cccd = dgv.SelectedRows[0].Cells[1].Value.ToString();
                Person per = ManagePerson.Instance.GetPersonByCCCD(cccd);
                fPaySalary f = new fPaySalary(per);
                f.ShowDialog();

            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Không thể trả lương cho nhiều nhân viên cùng lúc!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 thông tin nhân viên!");
            }
        }
    }
}
