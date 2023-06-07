using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;
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
    public partial class fDetailStaff : Form
    {
        Person staff;
        public fDetailStaff(Person p)
        {
            InitializeComponent();
            staff = p;
            GUI();
        }

        private void GUI()
        {
            tb_Name.Text = staff.Name;
            tb_DOB.Text = staff.DOB.Value.ToString("dd/MM/yyyy");
            tb_CCCD.Text = staff.CCCD;
            tb_PhoneNum.Text = staff.PhoneNum;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ManagePerson.Instance.updatePerson(staff.ID_Person, tb_Name.Text, Convert.ToDateTime(tb_DOB.Text), tb_CCCD.Text, tb_PhoneNum.Text);
            MessageBox.Show("Thay đổi thông tin thành công");
        }
    }
}
