using PBL3_LastReal.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PBL3_LastReal.DTO;


namespace PBL3_LastReal.View
{
    public partial class fWorkShift : Form
    {
        uc_DetailWorkShift selected_Compo;
        DateTime date;
        DateTime timeBegin;
        DateTime timeEnd;
        List<WorkShift> ws_Staff;
        List<WorkShift> ws_Cashier;
        List<WorkShift> ws_Guard;
        public fWorkShift(DateTime t)
        {
            InitializeComponent();
            date = t;
            GUI();
        }
        private void setTime()
        {
            string str_TimeBegin = selected_Compo.Controls["panel1"].Controls["tb_TimeBegin"].Text;
            string str_TimeEnd = selected_Compo.Controls["panel1"].Controls["tb_TimeEnd"].Text;
            string str_Date = ToolTime.Instance.getDate(date);
            timeBegin = ToolTime.Instance.trueTime(str_TimeBegin, str_Date);
            timeEnd = ToolTime.Instance.trueTime(str_TimeEnd, str_Date);
        }
        private void selectComponent()
        {
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Controls.ContainsKey("flp_Staff"))
            {
                foreach (Control item in flp_Staff.Controls)
                {
                    if (item.BackColor == SystemColors.GrayText)
                    {
                        selected_Compo = (uc_DetailWorkShift)item;
                        break;
                    }
                }
            }
            else if(tabControl1.TabPages[tabControl1.SelectedIndex].Controls.ContainsKey("flp_Cashier"))
            {
                foreach (Control item in flp_Cashier.Controls)
                {
                    if (item.BackColor == SystemColors.GrayText)
                    {
                        selected_Compo = (uc_DetailWorkShift)item;
                        break;
                    }
                }
            }
            else
            {
                foreach (Control item in flp_Guard.Controls)
                {
                    if (item.BackColor == SystemColors.GrayText)
                    {
                        selected_Compo = (uc_DetailWorkShift)item;
                        break;
                    }
                }
            }
        }
        private void GUI()
        {
            int index_staff = 0;
            ws_Staff = ManageWorkShift.Instance.GetWorkShifts(0, date);
            flp_Staff.Controls.Clear();
            foreach (WorkShift ws in ws_Staff)
            {
                index_staff++;
                uc_DetailWorkShift detail = new uc_DetailWorkShift(ws)
                {
                    Parent = this,
                    Name = "detail_" + index_staff
                };
                detail.Controls["panel1"].Controls["tb_TimeBegin"].Enabled = false;
                detail.Controls["panel1"].Controls["tb_TimeEnd"].Enabled = false;
                flp_Staff.Controls.Add(detail);
            }

            int index_cashier = 0;
            ws_Cashier = ManageWorkShift.Instance.GetWorkShifts(1, date);
            flp_Cashier.Controls.Clear();
            foreach (WorkShift ws in ws_Cashier)
            {
                index_cashier++;
                uc_DetailWorkShift detail = new uc_DetailWorkShift(ws)
                {
                    Parent = this,
                    Name = "detail_" + index_cashier
                };
                detail.Controls["panel1"].Controls["tb_TimeBegin"].Enabled = false;
                detail.Controls["panel1"].Controls["tb_TimeEnd"].Enabled = false;
                flp_Cashier.Controls.Add(detail);
            }

            int index_guard = 0;
            ws_Guard = ManageWorkShift.Instance.GetWorkShifts(2, date);
            flp_Guard.Controls.Clear();
            foreach (WorkShift ws in ws_Guard)
            {
                index_guard++;
                uc_DetailWorkShift detail = new uc_DetailWorkShift(ws)
                {
                    Parent = this,
                    Name = "detail_" + index_guard
                };
                detail.Controls["panel1"].Controls["tb_TimeBegin"].Enabled = false;
                detail.Controls["panel1"].Controls["tb_TimeEnd"].Enabled = false;
                flp_Guard.Controls.Add(detail);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fDetailWorkShift f = new fDetailWorkShift(date, null);
            f.UpdateData += new fDetailWorkShift.UpdateDataHandler(GUI);
            f.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            selectComponent();

            setTime();

            WorkShift ws = ManageWorkShift.Instance.GetWorkShift(date, timeBegin, timeEnd);

            fDetailWorkShift f = new fDetailWorkShift(date, ws);
            f.UpdateData += new fDetailWorkShift.UpdateDataHandler(GUI);
            f.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            selectComponent();

            setTime();

            WorkShift ws = ManageWorkShift.Instance.GetWorkShift(date, timeBegin, timeEnd);

            ManageWorkShift.Instance.DeleteWorkShift(ws);
            GUI();
            MessageBox.Show("Xóa ca thành công");
        }

        private void btn_DetailStaff_Click(object sender, EventArgs e)
        {
            selectComponent();

            setTime();

            WorkShift ws = ManageWorkShift.Instance.GetWorkShift(date, timeBegin, timeEnd);

            fStaffFree f = new fStaffFree(ws);
            f.ShowDialog();

            this.Controls.RemoveByKey("dgv_Person");
        }
    }
}
