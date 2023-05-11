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
        public fAddEditStaff()
        {
            InitializeComponent();
            setCBB();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void setCBB()
        {
            cbb_type.Items.Add("Nhân viên");
            cbb_type.Items.Add("Thu ngân");
            cbb_type.Items.Add("Bảo vệ");
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string type = cbb_type.Text;
            string name = tb_name.Text;
            string dob = dt_dob.Text;
            string cccd = tb_cccd.Text;
            string phoneNum = tb_phone.Text;
            string salary = tb_salary.Text;
            if(type == "" || name == "" || dob == "" || cccd == "" || phoneNum == "" || salary == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if(ManagePerson.Instance.checkCCCDPer(cccd) == false)
                {
                    ManageSalary.Instance.addSalaryAndPer(type, name, Convert.ToDateTime(dob), cccd, phoneNum, Convert.ToInt32(salary));
                    MessageBox.Show("Thêm thông tin nhân viên thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("CCCD này đã có người đăng ký!");
                }
                UpdateDGV();
            }    
        }
    }
}
