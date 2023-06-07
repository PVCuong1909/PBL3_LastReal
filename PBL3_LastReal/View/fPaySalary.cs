using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;


namespace PBL3_LastReal.View
{
    public partial class fPaySalary : Form
    {
        public fPaySalary(Person per)
        {
            InitializeComponent();
            GUI(per);
        }
        private void GUI(Person per)
        {
            Account acc = ManageAccount.Instance.getAccountByID_per(per.ID_Person);
            if(acc.Type == 2)
            {
                cbb_type.Text = "Nhân viên";
            }
            else if(acc.Type == 3)
            {
                cbb_type.Text = "Bảo vệ";
            }
            else
            {
                cbb_type.Text = "Thu ngân";
            }
            tb_name.Text = per.Name;
            tb_CCCD.Text = per.CCCD;
            tb_phone.Text = per.PhoneNum;
            dt_dob.Value = per.DOB.Value;
            string id = per.ID_Person.ToString();
            Salary sar = ManageSalary.Instance.getSalaryByID(Convert.ToInt32(id));
            tb_salary.Text = sar.Salary1.ToString();
            tb_work.Text = acc.Works.ToString();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if(tb_bonus.Text == "")
            {
                MessageBox.Show("Nhập lương thưởng cho nhân viên!");
            }
            else
            {
                int work = Convert.ToInt32(tb_work.Text);
                int salaryDay = Convert.ToInt32(tb_salary.Text);
                int bonus = Convert.ToInt32(tb_bonus.Text);
                int total = work * salaryDay + bonus;
                tb_total.Text = total.ToString();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
            if(tb_total.Text == "")
            {
                MessageBox.Show("Chưa tính tiền công nhân viên!");
            }
            else
            {
                string cccd = tb_CCCD.Text;
                MessageBox.Show("Trả tiền lương thành công!");
                ManagePerson.Instance.resetWork(cccd);
                this.Dispose();
            } 
                
        }
    }
}
