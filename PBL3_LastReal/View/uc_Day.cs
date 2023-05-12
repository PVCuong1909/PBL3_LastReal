using PBL3_LastReal.BLL;
using PBL3_LastReal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_LastReal.Resources
{
    public partial class uc_Day : UserControl
    {
        private int day, month, year;
        public uc_Day(int day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
            GUI();
        }
        public void GUI()
        {
            DateTime now = DateTime.Now;
            label1.Text = day.ToString();
            if (day == now.Day && month == now.Month && year == now.Year)
            {
                this.BackColor = System.Drawing.Color.Aquamarine;
            }
            else if(day != now.Day && month == now.Month && year == now.Year || month != now.Month || year != now.Year)
            {
                string date = year + "-" + month + "-" + day;
                if(ManageWorkShift.Instance.GetWorkShifts(Convert.ToDateTime(date)).Count > 0)
                {
                    this.BackColor = Color.OrangeRed;
                }
            }
        }
        private void uc_Day_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (day < now.Day && month == now.Month && year == now.Year || month < now.Month || year < now.Year)
            {
                fWorkShift f = new fWorkShift(ToolTime.Instance.trueTime(day, month, year));
                f.Controls["btn_DetailStaff"].Visible = false;
                f.Controls["btn_Add"].Visible = false;
                f.Controls["btn_Edit"].Visible = false;
                f.Controls["btn_Delete"].Visible = false;
                f.ShowDialog();
            }
            else
            {
                fWorkShift f = new fWorkShift(ToolTime.Instance.trueTime(day, month, year));
                f.ShowDialog();
            }
        }
    }
}
