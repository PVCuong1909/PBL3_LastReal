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
    public partial class fAddEditStaff : Form
    {
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fAddEditStaff(Salary s)
        {
            InitializeComponent();
            GUI(s);
        }
        private void GUI(Salary s)
        {
            if(s != null) 
            {
                tb_id.Text = s.ID_Person.ToString();
                tb_id.Enabled= false;
                tb_name.Text = s.Person.Name;
                tb_cccd.Text = s.Person.CCCD.ToString();
                tb_dob.Text = s.Person.DOB.ToString();
                tb_phone.Text = s.Person.PhoneNum.ToString();
                tb_salary.Text = s.Salary1.ToString();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string id_per = tb_id.Text;
            string name = tb_name.Text;
            string dob = tb_dob.Text;
            string cccd = tb_cccd.Text;
            string phoneNum = tb_phone.Text;
            string salary = tb_salary.Text;
            if(id_per == "" || name == "" || dob == "" || cccd == "" || phoneNum == "" || salary == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (ManagePerson.Instance.checkIDPer(Convert.ToInt32(id_per)) == true && tb_id.Enabled == false)
                {
                    ManageSalary.Instance.editSalaryAndPer(Convert.ToInt32(id_per), name, Convert.ToDateTime(dob), cccd, phoneNum, Convert.ToInt32(salary));
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
                else if (ManagePerson.Instance.checkIDPer(Convert.ToInt32(id_per)) == false)
                {
                    ManageSalary.Instance.addSalaryAndPer(name, Convert.ToDateTime(dob), cccd, phoneNum, Convert.ToInt32(salary));
                    MessageBox.Show("Thêm thông tin nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("ID này đã có trong danh sách!");
                }
                UpdateDGV();
                this.Dispose();
            }    
        }
    }
}
