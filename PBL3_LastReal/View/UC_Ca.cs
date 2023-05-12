using PBL3_LastReal.BLL;
using PBL3_LastReal.Resources;
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
    public partial class UC_Ca : UserControl
    {
        int month, year;
        public UC_Ca()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            flp_Calendar.Controls.Clear();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            lb_MonthYear.Text = month.ToString() + "/" + year.ToString();
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                uc_Blank blank = new uc_Blank();
                flp_Calendar.Controls.Add(blank);
            }    
            for(int i = 1; i <= days; i++) 
            {
                uc_Day day = new uc_Day(i, month, year);
                flp_Calendar.Controls.Add(day);
            }
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            flp_Calendar.Controls.Clear();
            month--;
            if(month == 0)
            {
                month = 12;
                year--;
            }
            lb_MonthYear.Text = month.ToString() + "/" + year.ToString();
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                uc_Blank blank = new uc_Blank();
                flp_Calendar.Controls.Add(blank);
            }
            for (int i = 1; i <= days; i++)
            {
                uc_Day day = new uc_Day(i, month, year);
                flp_Calendar.Controls.Add(day);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            flp_Calendar.Controls.Clear();
            month++;
            if(month == 13)
            {
                month = 1;
                year++;
            }
            lb_MonthYear.Text = month.ToString() + "/" + year.ToString();
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                uc_Blank blank = new uc_Blank();
                flp_Calendar.Controls.Add(blank);
            }
            for (int i = 1; i <= days; i++)
            {
                uc_Day day = new uc_Day(i, month, year);
                flp_Calendar.Controls.Add(day);
            }
        }
    }
}
