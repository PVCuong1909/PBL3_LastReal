using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;
namespace PBL3_LastReal
{
    public partial class UC_DoanhThu : UserControl
    {
        List<DataPoint> points = new List<DataPoint>();
        List<DataPoint> points2 = new List<DataPoint>();
        List<DataPoint> points3 = new List<DataPoint>();

        List<int> HourDV = new List<int>();
        List<int> HourMay = new List<int>();
        public UC_DoanhThu()
        {
            InitializeComponent();
            newGUI(DateTime.Now.ToString("yyyy-MM-dd"));
            GUI3();
        }

        public void newGUI(string date)
        {
            DateTime loadedDate = Convert.ToDateTime(date);
            for (int i = 0; i <= 11; i++)
            {
                HourDV.Add(0);
                HourMay.Add(0);
            }
            DateTime dm = DateTime.Now.Date;
            List<Bill> billsInDay = ManageProfit.Instance.getBills(loadedDate);
            int pos = 0;
            for (int i = 0; i <= 22; i += 2)
            {
                List<Bill> querybill = billsInDay.Where(p => p.Date.Value.CompareTo(loadedDate.Date.AddHours(i)) >= 0 && p.Date.Value.CompareTo(loadedDate.Date.AddHours(i + 2)) <= 0).ToList();
                foreach (var item in querybill)
                {
                    if (item.Type == 0)
                    {
                        HourDV[pos] += (int)item.Money;
                    }
                    else if (item.Type == 1)
                    {
                        HourMay[pos] += (int)item.Money;
                    }
                }
                pos++;
            }
            int count2 = 0;
            for (int i = 0; i <= 24; i += 2)
            {
                if (i == 0)
                {
                    chart1.Series["DichVu"].Points.AddXY(0, 0);
                    chart1.Series["TienMay"].Points.AddXY(0, 0);
                }
                else
                {
                    chart1.Series["DichVu"].Points.AddXY(i, HourDV[count2]);
                    chart1.Series["TienMay"].Points.AddXY(i, HourMay[count2]);
                    count2++;
                }
            }
            this.chart1.ChartAreas[0].AxisX.Maximum = 24;
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
        }
        void setValues(string month, int type)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            int monthNumber = 0;
            if (type == 0)
            {
                monthNumber = Convert.ToInt32(month);
            }
            else
            {
                monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
            }

            points = new List<DataPoint>();
            points2 = new List<DataPoint>();
            points3 = new List<DataPoint>();

            DateTime dm = new DateTime(DateTime.Now.Year, monthNumber, 1);

            int count = 0;
            List<Bill> query = ManageProfit.Instance.getBillsInMonth(dm);

            List<Bill> billsForRecharge = query.Where(p => p.Type == 0).ToList();
            List<Bill> billsForService = query.Where(p => p.Type == 1).ToList();
            List<Bill> billsForSalary = query.Where(p => p.Type == 2).ToList();

            int moneyRecharge = 0;
            int moneyService = 0;
            int moneySalary = 0;

            for (int i = 0; i < DateTime.DaysInMonth(DateTime.Now.Year, monthNumber); i++)
            {
                moneyRecharge = 0;
                moneyService = 0;
                moneySalary = 0;
                DateTime day = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + monthNumber.ToString() + "-" + (i + 1).ToString());

                    if (dm.AddDays(i).ToString("MM:dd") == (Convert.ToDateTime(query[count].Date).ToString("MM:dd")))
                    {
                        points.Add(new DataPoint(dm.AddDays(i).ToOADate(), (double)query[count].DichVu));
                        points2.Add(new DataPoint(dm.AddDays(i).ToOADate(), (double)query[count].TienMay));
                        points3.Add(new DataPoint(dm.AddDays(i).ToOADate(), query[count].LuongNhanVien));
                        count++;
                        if (count == query.Count)
                        {
                            count--;
                        }
                    }
                    else
                    {
                        moneySalary += (int)item.Money;
                    }
                }

                points.Add(new DataPoint(dm.AddDays(i).ToOADate(), moneyService));
                points2.Add(new DataPoint(dm.AddDays(i).ToOADate(), moneyRecharge));
                points3.Add(new DataPoint(dm.AddDays(i).ToOADate(), moneySalary));
            }
        }

        public void GUI3()
        {
            Chart chart = chart2;
            Series s = chart.Series[0];
            Series s2 = chart.Series[1];
            Series s3 = chart.Series[2];

            s.ChartType = SeriesChartType.Line;
            s.XValueType = ChartValueType.DateTime;
            s.YValueType = ChartValueType.Double;

            s2.ChartType = SeriesChartType.Line;
            s2.XValueType = ChartValueType.DateTime;
            s2.YValueType = ChartValueType.Double;

            s3.ChartType = SeriesChartType.Line;
            s3.XValueType = ChartValueType.DateTime;
            s3.YValueType = ChartValueType.Double;
            if (cbb.SelectedItem == null)
            {
                setValues(DateTime.Now.Month.ToString(), 0);
            }
            else
            {
                setValues(cbb.SelectedItem.ToString(), 1);
            }

            Axis ax = chart.ChartAreas[0].AxisX;
            Axis ay = chart.ChartAreas[0].AxisY;
            ax.Interval = 1;

            ax.IntervalType = DateTimeIntervalType.Days;
            ax.LabelStyle.Format = "dd";

            foreach (var dp in points) s.Points.Add(dp);
            foreach (var dp in points2) s2.Points.Add(dp);
            foreach (var dp in points3) s3.Points.Add(dp);

            ax.Minimum = points.Min(x => x.XValue);
            ax.Maximum = points.Max(x => x.XValue);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            GUI3();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i <= 11; i++)
            {
                HourDV[i] = 0;
                HourMay[i] = 0;
            }
            newGUI(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }
    }
}
