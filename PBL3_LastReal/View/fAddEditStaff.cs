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
using PBL3_LastReal.DTO;


namespace PBL3_LastReal.View
{
    public partial class fAddEditStaff : Form
    {
        private int id_per;
        public delegate void UpdateDGVHandler();
        public event UpdateDGVHandler UpdateDGV;
        public fAddEditStaff(Person per)
        {
            InitializeComponent();
            GUI(per);
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void GUI(Person per)
        {
            if (per != null)
            {
                tb_cccd.Text = per.CCCD;
                tb_cccd.Enabled = false;
                tb_name.Text = per.Name;
                tb_phone.Text = per.PhoneNum;
                Account acc = ManageAccount.Instance.getAccountByID_per(per.ID_Person);
                tb_user.Text = acc.Username;
                tb_user.Enabled = false;
                tb_pass.Enabled = false;
                if (acc.Type == 2)
                {
                    cbb_type.Text = "Nhân viên";
                }
                else if (acc.Type == 4)
                {
                    cbb_type.Text = "Thu ngân";
                }
                else if (acc.Type == 3)
                {
                    cbb_type.Text = "Bảo vệ";
                }
                dt_dob.Value = per.DOB.Value;
                id_per = per.ID_Person;
                Salary sal = ManageSalary.Instance.getSalaryByID(id_per);
                tb_salary.Text = sal.Salary1.ToString();
            }
            setCBB();
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
            string id ="";
            if (type == "Nhân viên")
            {
                id = "staff" + ManageAccount.Instance.getNextID_Acc("staff").ToString();
            }
            else if (type == "Bảo vệ")
            {
                id = "guard" + ManageAccount.Instance.getNextID_Acc("guard").ToString();
            }
            else if (type == "Thu ngân")
            {
                id = "cashier" + ManageAccount.Instance.getNextID_Acc("cashier").ToString();
            }
            string name = tb_name.Text;
            string dob = dt_dob.Text;
            string cccd = tb_cccd.Text;
            string phoneNum = tb_phone.Text;
            string salary = tb_salary.Text;
            string user = tb_user.Text;
            string pass = tb_pass.Text;
            if (type == "" || name == "" || dob == "" || cccd == "" || phoneNum == "" || salary == "" || user == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (tb_cccd.Enabled == false)
                {
                    if (tb_pass.Enabled == true)
                    {
                        ManageSalary.Instance.editSalaryAndAcc(Convert.ToInt32(id_per), type, name, Convert.ToDateTime(dob), phoneNum, Convert.ToInt32(salary), pass);
                    }
                    else
                    {
                        ManageSalary.Instance.editSalaryAndPer(Convert.ToInt32(id_per), type, name, Convert.ToDateTime(dob), phoneNum, Convert.ToInt32(salary));
                    }
                    MessageBox.Show("Cập nhật thông tin thành công");
                    this.Dispose();
                }
                else
                {
                    if (ManagePerson.Instance.checkCCCDPer(cccd) == false)
                    {
                        ManageSalary.Instance.addSalaryAndPer(type, name, Convert.ToDateTime(dob), cccd, phoneNum, Convert.ToInt32(salary), user, pass, id);
                        MessageBox.Show("Thêm thông tin nhân viên thành công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("CCCD này đã có người đăng ký!");
                    }
                }
                UpdateDGV();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_pass.Enabled = true;
        }
    }
}