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
    public partial class fStaff : Form
    {
        DateTime timeBegin;
        int lastComp;
        int firstComp;
        int end = ManageComputer.Instance.getAllComputer().Count;
        Account staff;
        public fStaff(Account acc)
        {
            InitializeComponent();
            staff = acc;
            timeBegin = DateTime.Now;
            ManageWorkShift.Instance.checkIn(ManageWorkShift.Instance.GetDetailWorkShift(timeBegin.Date, acc.ID_Account), 1);
            GUI();
        }

        private void GUI()
        {
            tb_ID.Text = staff.ID_Account;
            tb_Name.Text = ManagePerson.Instance.GetPerson(ManagePerson.Instance.getIDPersonByUsername(staff.Username)).Name;
            Computer com;
            for(int i = 1; i <= 9; i++)
            {
                com = ManageComputer.Instance.getComputerByID(i.ToString());
                uc_Comp uc = new uc_Comp((int)com.State, com.ID_Computer.ToString());
                flp_Comp.Controls.Add(uc);
            }
            firstComp = 1;
            lastComp = 9;
        }
        private void ptb_Pic_Click(object sender, EventArgs e)
        {
            Person p = ManagePerson.Instance.GetPerson((int)staff.ID_Person);
            fDetailStaff f = new fDetailStaff(p);
            f.ShowDialog();
        }
        private void btn_Pre_Click(object sender, EventArgs e)
        {
            if(firstComp != 1)
            {
                Computer com;
                if (flp_Comp.Controls.Count > 0)
                {
                    flp_Comp.Controls.Clear();
                }
                for (int i = firstComp - 9; i <= firstComp - 1; i++)
                {
                    com = ManageComputer.Instance.getComputerByID(i.ToString());
                    flp_Comp.Controls.Add(new uc_Comp((int)com.State, com.ID_Computer.ToString()));
                }
                firstComp -= 9;
                lastComp -= 9;
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(lastComp < end)
            {
                Computer com;
                if (flp_Comp.Controls.Count > 0)
                {
                    flp_Comp.Controls.Clear();
                }
                if(lastComp + 9 <= end)
                {
                    for (int i = lastComp + 1; i <= lastComp + 9; i++)
                    {
                        com = ManageComputer.Instance.getComputerByID(i.ToString());
                        flp_Comp.Controls.Add(new uc_Comp((int)com.State, com.ID_Computer.ToString()));
                    }
                }
                else
                {
                    for (int i = lastComp + 1; i <= end; i++)
                    {
                        com = ManageComputer.Instance.getComputerByID(i.ToString());
                        flp_Comp.Controls.Add(new uc_Comp((int)com.State, com.ID_Computer.ToString()));
                    }
                }
                firstComp += 9;
                lastComp += 9;
            }
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DetailWorkShift detail = ManageWorkShift.Instance.GetDetailWorkShift(timeBegin.Date, staff.ID_Account);
            if(detail.WorkShift.TimeBegin >= timeBegin && detail.WorkShift.TimeEnd <= DateTime.Now)
            {
                ManageWorkShift.Instance.checkIn(detail, 2);
            }
            if(ManageWorkShift.Instance.GetDetailWorkShift(timeBegin.Date, staff.ID_Account).State == 1)
            {
                ManageAccount.Instance.addWork(staff.ID_Account, 1);
            }
            else
            {
                ManageAccount.Instance.addWork(staff.ID_Account, 2);
            }
            this.Close();
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            fPassword f = new fPassword(staff.ID_Account);
            f.ShowDialog();
        }
        private void btn_ShowOrder_Click(object sender, EventArgs e)
        {
            fOrder f = new fOrder();
            f.ShowDialog();
        }
    }
}
